﻿using System.Reflection;
using ModularPipelines.Attributes;

namespace ModularPipelines.Engine;

internal class SecretProvider : ISecretProvider
{
    private readonly IOptionsProvider _optionsProvider;
    public string[] Secrets => GetSecrets(_optionsProvider.GetOptions()).ToArray();

    public SecretProvider(IOptionsProvider optionsProvider)
    {
        _optionsProvider = optionsProvider;
    }

    private IEnumerable<string> GetSecrets(IEnumerable<object?> options)
    {
        foreach (var option in options)
        {
            foreach (var secret in GetSecrets(option))
            {
                yield return secret;
            }
        }
    }

    public IEnumerable<string> GetSecrets(object? option)
    {
        if (option is null)
        {
            yield break;
        }

        foreach (var secretValueMember in option.GetType()
                     .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                     .Concat(option.GetType()
                         .GetProperties(BindingFlags.NonPublic | BindingFlags.Instance))
                     .Where(m => m.GetCustomAttribute<SecretValueAttribute>() is not null))
        {
            var secret = secretValueMember.GetValue(option)?.ToString();

            if (!string.IsNullOrWhiteSpace(secret))
            {
                yield return secret;
            }
        }
    }
}
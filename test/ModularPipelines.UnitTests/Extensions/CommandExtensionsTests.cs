﻿using ModularPipelines.Extensions;
using ModularPipelines.Options;
using TUnit.Assertions.Extensions;

namespace ModularPipelines.UnitTests.Extensions;

public class CommandExtensionsTests
{
    [Test]
    public async Task ToToolOptions_SingleArg()
    {
        var commandLineOptions = new CommandLineOptions()
            .ToCommandLineToolOptions("mytool", "arg1");
        
        await using (Assert.Multiple())
        {
            Assert.That(commandLineOptions.Tool).Is.EqualTo("mytool");
            Assert.That(commandLineOptions.Arguments!).Is.EquivalentTo(new[] { "arg1" });
        });
    }

    [Test]
    public async Task ToToolOptions_MultipleArgs()
    {
        var commandLineOptions = new CommandLineOptions()
            .ToCommandLineToolOptions("mytool", ["arg1", "arg2"]);
        
        await using (Assert.Multiple())
        {
            Assert.That(commandLineOptions.Tool).Is.EqualTo("mytool");
            Assert.That(commandLineOptions.Arguments!).Is.EquivalentTo(new[] { "arg1", "arg2" });
        });
    }
    
    [Test]
    public async Task ToToolOptions_MultipleArgs_IEnumerable()
    {
        var commandLineOptions = new CommandLineOptions()
            .ToCommandLineToolOptions("mytool", new HashSet<string>(["arg1", "arg2"]));
        
        await using (Assert.Multiple())
        {
            Assert.That(commandLineOptions.Tool).Is.EqualTo("mytool");
            Assert.That(commandLineOptions.Arguments!).Is.EquivalentTo(new[] { "arg1", "arg2" });
        });
    }

    [Test]
    public async Task WithArguments_AddsToExisting()
    {
        var commandLineOptions = new CommandLineOptions()
            .ToCommandLineToolOptions("mytool", ["arg1", "arg2"])
            .WithArguments(["arg3", "arg4", "arg5"]);
        
        await using (Assert.Multiple())
        {
            Assert.That(commandLineOptions.Tool).Is.EqualTo("mytool");
            Assert.That(commandLineOptions.Arguments!).Is.EquivalentTo(new[] { "arg1", "arg2", "arg3", "arg4", "arg5" });
        });
    }
}
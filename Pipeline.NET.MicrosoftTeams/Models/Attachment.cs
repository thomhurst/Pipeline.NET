﻿using System.Text.Json.Serialization;

namespace Pipeline.NET.MicrosoftTeams.Models;

internal class Attachment
{
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }
        
    [JsonPropertyName("content")]
    public MicrosoftTeamsAdaptiveCard? Content { get; set; }
}
﻿using Pipeline.NET.Context;
using Pipeline.NET.Git;

namespace Pipeline.NET.Examples.Modules;

public class GitVersionModule : GitModule
{
    public GitVersionModule(IModuleContext context) : base(context)
    {
    }

    protected override IEnumerable<string> Arguments
    {
        get { yield return "--version"; }
    }
}
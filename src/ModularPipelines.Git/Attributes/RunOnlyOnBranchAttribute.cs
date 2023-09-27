﻿using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Git.Extensions;

namespace ModularPipelines.Git.Attributes;

public class RunOnlyOnBranchAttribute : MandatoryRunConditionAttribute
{
    public string BranchName { get; }

    public RunOnlyOnBranchAttribute(string branchName)
    {
        BranchName = branchName;
    }
    
    public override Task<bool> Condition(IPipelineContext pipelineContext)
    {
        return Task.FromResult(pipelineContext.Git().Information.BranchName == BranchName);
    }
}
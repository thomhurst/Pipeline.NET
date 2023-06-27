﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using VerifyCS = ModularPipelines.Analyzers.Test.Verifiers.CSharpCodeFixVerifier<
    ModularPipelines.Analyzers.MissingDependsOnAttributeAnalyzer,
    ModularPipelines.Analyzers.MissingDependsOnAttributeCodeFixProvider>;

namespace ModularPipelines.Analyzers.Test;

[TestClass]
public class ModularPipelinesAnalyzersUnitTest
{
    private const string BadModuleSource = @"
#nullable enable
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Modules;

namespace ModularPipelines.Examples.Modules;

public class Module1 : Module
{
    protected override async Task<ModuleResult<IDictionary<string, object>>?> ExecuteAsync(IModuleContext context, CancellationToken cancellationToken)
    {
        await Task.Delay(1, cancellationToken);
        return null;
    }
}

public class Module2 : Module
{
    protected override async Task<ModuleResult<IDictionary<string, object>>?> ExecuteAsync(IModuleContext context, CancellationToken cancellationToken)
    {
        var module1 = await {|#0:GetModule<Module1>()|};
        return null;
    }
}";

    private const string FixedModuleSource = @"
#nullable enable
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Modules;
using ModularPipelines.Attributes;

namespace ModularPipelines.Examples.Modules;

public class Module1 : Module
{
    protected override async Task<ModuleResult<IDictionary<string, object>>?> ExecuteAsync(IModuleContext context, CancellationToken cancellationToken)
    {
        await Task.Delay(1, cancellationToken);
        return null;
    }
}

[DependsOn(typeof(Module1))]
public class Module2 : Module
{
    protected override async Task<ModuleResult<IDictionary<string, object>>?> ExecuteAsync(IModuleContext context, CancellationToken cancellationToken)
    {
        var module1 = await GetModule<Module1>();
        return null;
    }
}";

    //No diagnostics expected to show up
    [TestMethod]
    public async Task TestMethod1()
    {
        var test = @"";

        await VerifyCS.VerifyAnalyzerAsync(test);
    }

    //Diagnostic and CodeFix both triggered and checked for
    [TestMethod]
    public async Task AnalyzerIsTriggered()
    {
        var expected = VerifyCS.Diagnostic("MissingDependsOnAttribute").WithArguments("Module1").WithLocation(0);
            
        await VerifyCS.VerifyAnalyzerAsync(BadModuleSource, expected);
    }
        
    [TestMethod]
    public async Task CodeFixWorks()
    {
        var expected = VerifyCS.Diagnostic("MissingDependsOnAttribute").WithArguments("Module1").WithLocation(0);

        await VerifyCS.VerifyCodeFixAsync(BadModuleSource, expected, FixedModuleSource);
    }
}
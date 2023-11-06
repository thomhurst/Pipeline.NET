using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace ModularPipelines.UnitTests.Attributes;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
public class WindowsOnlyTestAttribute : Attribute, IApplyToTest
{
    /// <inheritdoc/>
    public void ApplyToTest(Test test)
    {
        if (!OperatingSystem.IsWindows())
        {
            test.RunState = RunState.Ignored;
        }
    }
}
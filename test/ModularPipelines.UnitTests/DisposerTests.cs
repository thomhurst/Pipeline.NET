using TUnit.Assertions.Extensions;
using Disposer = ModularPipelines.Helpers.Disposer;

namespace ModularPipelines.UnitTests;

public class DisposerTests
{
    private class MyClass : IAsyncDisposable
    {
        public bool DisposedAsync { get; private set; }

        public ValueTask DisposeAsync()
        {
            DisposedAsync = true;
            return ValueTask.CompletedTask;
        }
    }

    private class MyClass2 : IDisposable
    {
        public bool Disposed { get; private set; }

        public void Dispose()
        {
            Disposed = true;
        }
    }

    [Test]
    public async Task Disposer_Calls_Async()
    {
        var myClass = new MyClass();
        await Assert.That(myClass.DisposedAsync).Is.False();

        await Disposer.DisposeObjectAsync(myClass);
        await Assert.That(myClass.DisposedAsync).Is.True();
    }

    [Test]
    public async Task Disposer_Calls_Sync()
    {
        var myClass = new MyClass2();
        await Assert.That(myClass.Disposed).Is.False();

        await Disposer.DisposeObjectAsync(myClass);
        await Assert.That(myClass.Disposed).Is.True();
    }
}
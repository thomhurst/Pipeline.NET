using ModularPipelines.Context;
using ModularPipelines.Git;
using ModularPipelines.TestHelpers;
using TUnit.Assertions;
using TUnit.Core;

namespace ModularPipelines.UnitTests.Helpers;

public class ChecksumTests : TestBase
{
    [Test]
    public async Task Md5_Checksum()
    {
        var git = await GetService<IGit>();

        var file = git.RootDirectory.FindFile(x => x.Name == "Foo.txt");

        var checksum = await GetService<IChecksum>();

        var calculatedMd5 = checksum.Md5(file!);

        Assert.That(calculatedMd5).Is.EqualTo("90EAEF2DB61DD9B2AF2B27F57785141E");
    }
}
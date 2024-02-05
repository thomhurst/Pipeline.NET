using ModularPipelines.Context;
using ModularPipelines.Options;
using ModularPipelines.TestHelpers;
using TUnit.Assertions;
using TUnit.Core;

namespace ModularPipelines.UnitTests.Helpers;

public class DownloaderTests : TestBase
{
    [Test]
    public async Task Can_Download()
    {
        var downloader = await GetService<IDownloader>();
        var checksum = await GetService<IChecksum>();

        var file = await downloader.DownloadFileAsync(new DownloadFileOptions(new Uri(
            "https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.5.7/npp.8.5.7.portable.minimalist.7z")));

        Assert.That(checksum.Md5(file)).Is.EqualTo("A7EE66BAC064F451BC3A758D16E33080");
    }
}
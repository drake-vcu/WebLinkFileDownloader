using System;
using System.Collections.Generic;
using WebLinkFileDownloader;
using Xunit;

namespace XUnitTestProject
{
    public class FileDownloaderTest
    {
        [Fact]
        public void FileDownloader_Test_Pass()
        {
            var downloader = new FileDownloader();
            var links = new List<string>();
            links.Add(@"https://switch-xci.com/wp-content/uploads/switchxcitorrent/Shaq_Fu_-_A_Legend_Reborn_(World)_(En,Fr,De,Es,It,Pt,Ru)_[Trimmed].torrent");
            downloader.DownloadLinkedFiles(links);
        }
    }
}

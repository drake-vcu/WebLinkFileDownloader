using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace WebLinkFileDownloader
{
    public class FileDownloader
    {
        private List<string> _urls;
        private readonly WebClient webClient;

        public FileDownloader()
        {
            webClient = new WebClient();
        }

        public void DownloadLinkedFiles(List<string> urls)
        {
            _urls = urls;
            foreach (var link in urls)
            {
                var fileName = link.Substring(link.LastIndexOf('/') + 1);
                webClient.DownloadFileAsync(new Uri(link), fileName);
            }
        }
    }
}

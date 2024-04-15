using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkModule18
{
    /// <summary>
    /// Класс-команда загрузки  видео
    /// </summary>
    internal class DownloadCommand : ICommand
    {
        VideoDownload _downloader;

        public DownloadCommand(VideoDownload downloader)
        {
            _downloader = downloader;
        }

        public void Execute()
        {
            _downloader.Download();
        }
    }
}

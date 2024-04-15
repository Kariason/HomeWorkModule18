using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;


namespace HomeWorkModule18
{
    /// <summary>
    /// Класс загрузки видео
    /// </summary>
    internal class VideoDownload
    {
        public string link { get; set; }
        public string fileName { get; set; }

        public VideoDownload(string link, string fileName)
        {
            this.link = link;
            this.fileName = fileName;
        }

        public async void Download()
        {
            var client = new YoutubeClient();

            var streamManifest = await client.Videos.Streams.GetManifestAsync(link);

            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await client.Videos.Streams.DownloadAsync(streamInfo, fileName);

            
        }
    }
}

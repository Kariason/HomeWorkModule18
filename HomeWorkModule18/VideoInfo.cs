using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace HomeWorkModule18
{
    /// <summary>
    /// Класс получения информации о видео
    /// </summary>
    internal class VideoInfo
    {
        public string link { get; set; }

        public VideoInfo(string link)
        {
            this.link = link;
        }

        public void ShowInfo()
        {
            var client = new YoutubeClient();
            var info = client.Videos.GetAsync(link);
            
            Console.WriteLine("Информация о видео:");
            Console.WriteLine(info.Result.Title);
        }
    }
}

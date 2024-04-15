using System;
using System.Reflection;
using System.Threading;
using System.IO;
using System.Threading.Tasks;

namespace HomeWorkModule18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ссылку на видео: ");
            string link = Console.ReadLine();

            Console.WriteLine("Введите название для файла");
            string fileName = Console.ReadLine();

            do
            {
                if (File.Exists(fileName))
                    Console.WriteLine("Файл с таким именем уже существует!\n Введите другое название!");
                fileName = Console.ReadLine();
            }
            while (File.Exists(fileName));

            var sender = new Sender();

            var videoInfo = new VideoInfo(link);
            var infoCommand = new GetInfoCommand(videoInfo);
            sender.SetCommand(infoCommand);
            sender.Run();

            var VideoDownload = new VideoDownload(link, fileName);
            var downloadCommand = new DownloadCommand(VideoDownload);
            sender.SetCommand(downloadCommand);
            sender.Run();
        }
    }
}

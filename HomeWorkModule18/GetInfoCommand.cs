using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkModule18
{
    /// <summary>
    /// Класс-команда получения информации о видео
    /// </summary>
    internal class GetInfoCommand : ICommand
    {
        VideoInfo _infoReciever;

        public GetInfoCommand(VideoInfo infoReciever)
        {
            _infoReciever = infoReciever;
        }

        public void Execute()
        {
            _infoReciever.ShowInfo();
        }
    }
}

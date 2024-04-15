using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkModule18
{
    /// <summary>
    /// Класс отправитель команды
    /// </summary>
    internal class Sender
    {
        ICommand _command;

        public void SetCommand(ICommand comand)
        {
            _command = comand;
        }

        public void Run()
        {
            _command.Execute();
        }
    }
}

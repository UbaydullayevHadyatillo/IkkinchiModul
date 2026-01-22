using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8_dars.Services
{
    internal class TeamsService : INotification
    {
        public void SendNotification()
        {
            Console.WriteLine("Hamma xodimlarga Teamsdan notification ketdi");
        }
    }
}

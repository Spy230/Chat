using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Chat;

namespace ChatHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Chat.ServiceChat)))
            {
                host.Open();
                Console.WriteLine("Host Start");
                Console.ReadLine();
            }
        }
    }
}

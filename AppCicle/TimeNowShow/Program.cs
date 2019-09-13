using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeNowShow
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                //Console.Clear();
                //Console.WriteLine($"Hora Atual: {DateTime.Now.ToString("dd:MM:HH:mm:ss:fffff")}");//Aqui eu coloco data e hora atual
                //Thread.Sleep(250);
                if (DateTime.Now.ToString("ss") == "03" || DateTime.Now.ToString("ss") == "13" )
                {
                    Console.WriteLine($"Hora Atual: {DateTime.Now.ToString("dd:MM:HH:mm:ss:fffff")}");//Aqui eu coloco data e hora atual
                }
            }
        }
    }
}

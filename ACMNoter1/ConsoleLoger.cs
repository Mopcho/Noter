using ACMNoter1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACMNoter1
{
    public class ConsoleLoger : ILoger
    {
        public void LogLine(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Log(string msg)
        {
            Console.Write(msg);
        }

        public string LogReadLine()
        {
            string a = Console.ReadLine();
            return a;
        }

        public void LogClear()
        {
            Console.Clear();
        }

        public void LogLineBase(string msg)
        {
            string[] msgArr = msg.Split('\r');
            foreach (var item in msgArr)
            {
                if (item.Contains("Good"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (item.Contains("Middle"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (item.Contains("Bad"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(item);
            }
            Console.ResetColor();
        }

        public void LogBase(string msg)
        {
            string[] msgArr = msg.Split('\r');
            foreach (var item in msgArr)
            {
                if (item.Contains("Good"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (item.Contains("Middle"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (item.Contains("Bad"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(item);
            }
            Console.ResetColor();
        }
    }
}

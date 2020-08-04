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
        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}

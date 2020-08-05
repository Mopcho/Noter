using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMNoter1.Interfaces
{
    public interface ILoger
    {
        void Log(string msg);
        void LogLine(string msg);
        string LogReadLine();
        void LogClear();
        void LogLineBase(string msg);
        void LogBase(string msg);
    }
}

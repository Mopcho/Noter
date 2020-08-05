using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACMNoter1.Interfaces;
using System.IO;

namespace ACMNoter1
{
    public class NotePadDB : IDB
    {

        public void Save(IContent activity, string directory)
        {
            directory += String.Format($"{activity.Year}-{activity.Month}-{activity.Day}.txt");
            File.AppendAllText(directory, String.Format($"{activity.Hour}:{activity.Minute} - {activity.Description} - {activity.IsGood}\r\n"));
        }

        public string Get(string year,string month,string day, string directory)
        {
            directory += String.Format($"{year}-{month}-{day}.txt");
            return File.ReadAllText(directory);
        }

        public void Clear(string directory)
        {
            
        }
    }
}

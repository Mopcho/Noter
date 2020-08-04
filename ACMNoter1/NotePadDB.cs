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
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{activity.DT.ToString()} - {activity.Description} - {activity.IsGood}");
            File.AppendAllText(directory, str.ToString());
        }

        public string Get(DateTime time, string directory)
        { 
            string holder = File.ReadAllText(directory);

            string[] arrHolder = holder.Split('\r');

            string[] dated = arrHolder
                .Where(x => x.Contains(time.ToString())).ToArray();

            return string.Join("\r\n", dated);
        }

        public string Get(string directory)
        {
            string holder = File.ReadAllText(directory);
            return holder;
        }

        public void Clear(string directory)
        {
            File.WriteAllText(directory, string.Empty);
        }
    }
}

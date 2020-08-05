using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMNoter1.Interfaces
{
    public interface IDB
    {
        void Save(IContent content,string directory);
        string Get(string year,string month,string day,string directory);
        void Clear(string directory);
    }
}

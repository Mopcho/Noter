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
        string Get(DateTime time,string directory);
        string Get(string directory);
        void Clear(string directory);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMNoter1.Interfaces
{
    public interface IContent
    {
        string Description { get; set; }
        bool IsGood { get; set; }
        DateTime DT { get; set; }
    }
}

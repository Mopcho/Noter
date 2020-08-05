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
        string IsGood { get; set; }
        string Year { get; set; }
        string Month { get; set; }
        string Day { get; set; }
        string Hour { get; set; }
        string Minute { get; set; }
    }
}

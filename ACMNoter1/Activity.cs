using ACMNoter1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMNoter1
{
    public class Activity : IContent
    {
        public string Description { get; set; }
        public bool IsGood {get;set;}
        public DateTime DT { get; set; }
        public Activity(string description,bool isGood,DateTime dt)
        {
            this.Description = description;
            this.IsGood = isGood;
            this.DT = dt;
        }
    }
}

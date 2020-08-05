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
        public string IsGood {get;set;}
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string Hour { get; set; }
        public string Minute { get; set; }
        public Activity(string description,string isGood,string year,string month,string day,string hour,string minute)
        {
            this.Description = description;
            this.IsGood = isGood;
            this.Year = year;
            this.Month = month;
            this.Day = day;
            this.Hour = hour;
            this.Minute = minute;
        }
    }
}

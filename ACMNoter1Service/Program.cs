using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACMNoter1;
using ACMNoter1.Interfaces;

namespace ACMNoter1Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var loger = new ConsoleLoger();
            var db = new NotePadDB();
            var activity = new Activity("aaaaaaaaaaaaaaa",true,new DateTime(2020,8,3));
            var activity2 = new Activity("bbbbbbbbbbbbbb", true, DateTime.Today);
            var noter = new Noter(db,loger,"C:/Users/PC/Desktop/DataBase/db.txt");
            noter.Save(activity);
            noter.Save(activity2);
            noter.ViewYesterday();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACMNoter1.Interfaces;

namespace ACMNoter1
{
    public class Noter
    {
        private IDB db;
        private ILoger loger;
        private string directory;

        public IDB DB { get; set; }

        public ILoger Loger { get; set; }

        public string Directory { get; set; }

        public Noter(IDB dB, ILoger loger, string directory)
        {
            if(db==null || loger == null || directory==null)
            {
                throw new ArgumentNullException();
            }
            this.DB = dB;
            this.Loger = loger;
            this.Directory = directory;
        }

        public void Save(IContent activity)
        {
            this.DB.Save(activity, this.Directory);
            this.Loger.Log($"Saved to {this.Directory}");
        }

        public void ViewToday()
        {
           string msg = this.DB.Get(DateTime.Today, this.Directory);
           this.Loger.Log(msg);
        }

        public void ViewAll()
        {
            string msg = this.DB.Get(this.Directory);
            this.Loger.Log(msg);
        }

        public void ViewYesterday()
        {
            DateTime dt = DateTime.Today;
            dt = dt.AddDays(-1);
            string msg = this.DB.Get(dt, this.Directory);
            this.Loger.Log(msg);
        }

        public void DeleteAll()
        {
            this.DB.Clear(this.Directory);
            this.Loger.Log("Database cleared");
        }

       //public void ViewMonth()
       //{
       //    string msg = this.DB.Get(DateTime.Today, this.Directory);
       //    this.Loger.Log(msg);
       //}
        
        //viewYear();
    }
}

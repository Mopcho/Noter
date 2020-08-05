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
        //-----------------Fields-----------------//
        private IDB db;

        private ILoger loger;

        private string folder;


        //-----------------Properties-----------------//
        public IDB DB
        {
            get
            {
                return this.db;
            }
            set
            {
                this.db = value;
            }
        }

        public ILoger Loger
        {
            get
            {
                return this.loger;
            }
            set
            {
                this.loger = value;
            }
        }

        public string Folder
        {
            get
            {
                return this.folder;
            }
            set
            {
                this.folder = value;
            }
        }


        //-----------------Constructors-----------------//
        public Noter(IDB dB, ILoger loger, string folder)
        {
            this.DB = dB;
            this.Loger = loger;
            this.Folder = folder;
        }


        //-----------------Methods-----------------//
        //Saves IContent to the database specified in the constructor
        public void Save(IContent activity)
        {
            this.DB.Save(activity, this.Folder);
            Loger.LogLine($"Saved to {this.Folder}");
        }

        //View the content of a file from the given date in the database folder
        public void View(string year,string month,string day)
        {
            Loger.LogLineBase(this.DB.Get(year, month, day, this.Folder));
        }

        //Starts the program
        public void Start()
        {
            while (true)
            {
                Loger.LogLine("Press `P` to add more activities or `V` to view activities on a specific date or `exit` to exit the program");
                string answer = Loger.LogReadLine();
                if (answer == "exit")
                {
                    return;
                }
                if(answer=="V")
                {
                    VSection(answer);
                }
                if(answer=="P")
                {
                    PSection(answer);
                }
            }
        }
        

        //-----------------Private Methods-----------------//
        private void VSection(string answer)
        {
            while (answer == "V")
            {
                Loger.Log("Year :");
                string yearV = Loger.LogReadLine();
                Loger.Log("Month :");
                string monthV = Loger.LogReadLine();
                Loger.Log("Day :");
                string dayV = Loger.LogReadLine();
                Loger.LogClear();

                this.View(yearV, monthV, dayV);

                Loger.LogLine("Press `P` to add more activities or `V` to view activities on a specific date or `exit` to exit the program");
                answer = Loger.LogReadLine();
                if (answer == "exit")
                {
                    return;
                }
            }
        }

        private void PSection(string answer)
        {
            Loger.Log("Description :");
            string description = Loger.LogReadLine();
            Loger.Log("Is it good or bad :");
            string isItGood = Loger.LogReadLine();
            Loger.Log("Year :");
            string year = Loger.LogReadLine();
            Loger.Log("Month :");
            string month = Loger.LogReadLine();
            Loger.Log("Day :");
            string day = Loger.LogReadLine();
            Loger.Log("Hour :");
            string hour = Loger.LogReadLine();
            Loger.Log("Minute :");
            string minute = Loger.LogReadLine();

            Activity activity = new Activity(description, isItGood, year, month, day, hour, minute);
            Loger.LogClear();
            this.Save(activity);
        }
    }
}

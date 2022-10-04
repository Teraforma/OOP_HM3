using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Console_Application
{
    abstract class Worker
    {
        protected string  Position, Workday = "0";
        private string Name;
        public Worker(string name)
        {
            Name = name;
        }

        public void Call()
        {
            Console.WriteLine(Name + " called  someone");
        }

        public void WriteCode() {
            Console.WriteLine(Name + "write smw code");
        }

        public void Relax() {
            Console.WriteLine(Name + "...relax...");
                }

        public string getFullInfo()
        {
            
            return (String.Format("{0} - {1} - {2}", Name, Position, Workday));
        }
        public string getName()
        {
            return Name;
        }
        abstract public void FillWorkDay();
    }



    class Developer: Worker
    {
        public Developer( string name): base(name)
        {
            this.Position = "dev";
        }

        public override void FillWorkDay()
        {
            this.WriteCode();
            this.Call();
            this.Relax ();
            this.WriteCode ();
        }
    }

    class Manager: Worker
    {
        Random rand = new Random();
        public Manager(string name) : base(name)
        {
            this.Position = "Manager";
        }

        public override void FillWorkDay()
        {   
            int rInt = rand.Next(1,10);
            for (int i = 0; i <= rInt; i++)
            {
                this.Call();
            }

            this.Relax();

             rInt = rand.Next(1,5);
            for (int i = 0; i <= rInt; i++)
            {
                this.Call();
            }
        }
    }


    class Team
    {
        public List<Worker> StuffMembers = new List<Worker>();
        private string Name;

        public Team(string name)
        {
            this.Name = name;
        }

        public void AddMember(Worker toAdd)
        {
            StuffMembers.Add(toAdd);
        }

        public void ShowUp()
        {
            Console.WriteLine(" Team name: " + Name + "\nIn team: ");
            for (var i = 0; i < StuffMembers.Count; i++)
            {
                Console.WriteLine( StuffMembers[i].getName());
            }
            if (StuffMembers.Count == 0)
            {
                Console.WriteLine(" empty");
            }
        }

        public void ShowUpPlus()
        {
            Console.WriteLine(String.Format(" Team name: {0}\nIn team: ", Name));
            for (var i = 0; i < StuffMembers.Count; i++)
            {
                Console.WriteLine(StuffMembers[i].getFullInfo());
            }
            if (StuffMembers.Count == 0)
            {
                Console.WriteLine(" empty");
            }
        }
    }

  


}

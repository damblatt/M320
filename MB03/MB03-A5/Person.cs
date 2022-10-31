using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB03_A5
{
    internal class Person
    {
        // field
        private int currentRage = 0;

        // property
        public int PreviousRage { get; set; }

        public int CurrentRage
        {
            get { return currentRage; }
            set
            {
                currentRage = value;
                if (CurrentRage < 0)
                {
                    CurrentRage = 0;
                }
            }
        }

        public string Operation { get; set; }
        
        public string Reason { get; set; }


        // constructor
        public Person(int ragePercentage, string reason = "")
        {
            PreviousRage = ragePercentage;
            CurrentRage = ragePercentage;
            Reason = reason;
        }


        // class
        public int RelieveRageWithSleep(int hoursOfSleep)
        {
            PreviousRage = CurrentRage;
            CurrentRage -= (10 * hoursOfSleep);
            Operation = "Sleep";
            return (10 * hoursOfSleep);
        }

        public int RelieveRageWithHugs(int amountOfHugs)
        {
            PreviousRage = CurrentRage;
            CurrentRage -= (5 * amountOfHugs);
            Operation = "Hugs";
            return (5 * amountOfHugs);
        }

        public int RelieveRageWithCannabis() // legal amount of thc ofc
        {
            var random = new Random();
            int randomValue = random.Next(-100, 100);
            PreviousRage = CurrentRage;
            CurrentRage += randomValue;
            Operation = "Cannabis";
            return randomValue;
        }

        public int GetCurrentRage()
        {
            return CurrentRage;
        }
    }
}

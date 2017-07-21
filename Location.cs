using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DlugieCwiczenie
{
    public abstract class Location
    {
      
       public string Name
        {
            get;
            private set;
        }
       public Location [] Exits;

        public Location(string inName)
        {
            Name = inName;
        }

        public virtual string Description
        {
            get
            {
                string description = "";

                description = "Stoisz w " + Name + ". Widzisz wyjścia do następujących lokalizacji: ";

                for (int i = 0; i < Exits.Length-1; i++)
                {
                    description += " " + Exits[i].Name +", ";
                   
                }

                description += Exits[Exits.Length - 1].Name + ".";

                return description;
            }
        }

    }
}

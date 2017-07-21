using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DlugieCwiczenie
{
    public class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location inLocation)
        {
            random = new Random();
            myLocation = inLocation;
        }

        public void Move()
        {
            bool isHidden = false;

            while (!isHidden)
            {
                if (myLocation is IHasExteriorDoor)
                {
                    if (random.Next(2) == 1)
                    {
                        IHasExteriorDoor myLocationWithDoor = myLocation as IHasExteriorDoor;
                        myLocation = myLocationWithDoor.DoorLocation;
                    }
                }

                int rand = random.Next(myLocation.Exits.Length);

                myLocation = myLocation.Exits[rand];

                    if (myLocation is IHidingLocation)
                      isHidden = true;                   
                
            }
        }

        public bool Check(Location checkedLocation)
        {
            if (checkedLocation == myLocation)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

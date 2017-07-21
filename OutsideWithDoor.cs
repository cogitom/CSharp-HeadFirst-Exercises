using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DlugieCwiczenie
{
    public class OutsideWithDoor : OutsideWithHidingLocation, IHasExteriorDoor
    {
        public OutsideWithDoor(string inName, bool inHot, string inDoorDescription, string inHidingPlace) : base(inName, inHot, inHidingPlace)
        {
            DoorDescription = inDoorDescription;
        
        }

        public string DoorDescription
        {
            get;
            private set;
        }

        public Location DoorLocation
        {
            get;
            set;
        }
    }
}

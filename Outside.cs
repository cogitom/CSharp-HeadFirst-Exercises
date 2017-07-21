using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DlugieCwiczenie
{
    public class Outside : Location
    {
        private bool hot;

        public override string Description
        {
            get
            {
                if (hot)
                {
                    return base.Description + "\r\n Tutaj jest bardzo gorąco!!!";
                }
                else
                {
                    return base.Description + "\r\n Nie jest gorąco.";
                }
            }
        }
            
        
        public Outside( string inName, bool inHot) : base(inName)
        {
            hot = inHot;
        }

    }
}

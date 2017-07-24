using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingAmazing.Things
{
    class Thing
    {
        //auto implemented properties
        public int XPos { get; set; }
        public int YPos { get; set; }

        //class constructor
        public Thing()
        {
        }

        //class methods
        public void MoveUp()
        {
            this.YPos--;
        }
        public void MoveDown()
        {
            this.YPos++;
        }
        public void MoveLeft()
        {
            this.XPos--;
        }
        public void MoveRight()
        {
            this.XPos++;
        }
        
    }
}

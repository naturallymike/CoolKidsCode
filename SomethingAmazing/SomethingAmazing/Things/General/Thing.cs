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
        public int xPos { get; set; }
        public int yPos { get; set; }

        //class constructor
        public Thing()
        {
        }

        //class methods
        public void MoveUp()
        {
            this.yPos--;
        }
        public void MoveDown()
        {
            this.yPos++;
        }
        public void MoveLeft()
        {
            this.xPos--;
        }
        public void MoveRight()
        {
            this.xPos++;
        }






    }
}

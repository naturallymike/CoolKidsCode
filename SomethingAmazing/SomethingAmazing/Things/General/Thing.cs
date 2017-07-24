using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingAmazing.Things
{
    class Thing : PhysicalForces
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
        
        public void MoveToTarget()
        {
            // These are variables that need to be made during Obj Creation
            int targetX = 20;
            int targetY = -50;
            int locationX = 20;
            int locationY = 100;
            int MoveValueX;
            int MoveValueY;
        
            MoveValueX = locationX - targetX;
            MoveValueY = locationY - targetY;



          xPos =  xPos + MoveValueX;
          yPos =  yPos + MoveValueY;

        }

        public void MoveToDiag()
        {
            // These are variables that need to be made during Obj Creation
            int targetX = 20;
            int targetY = -50;
            int locationX = 20;
            int locationY = 100;
            int MoveValueX;
            int MoveValueY;

            MoveValueX = locationX - targetX;
            MoveValueY = locationY - targetY;

            if (xPos > xPos + MoveValueX)
            {
                xPos++;
            }
            if (xPos < xPos + MoveValueX)
            {
                xPos--;
            }


            if (yPos > yPos + MoveValueY)
            {
                yPos++;
            }
            if (yPos < yPos + MoveValueY)
            {
                yPos--;
            }

        }





    }
}

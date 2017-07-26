using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SomethingAmazing.Strings;

namespace SomethingAmazing.Stories
{   
      
    public class StoryLogic
    {


        Reply p = new Reply();
      


        // Issues with the foreach loop. I need to access the string arrays inside the logic loop but I am getting errors. 

        public void StringCruncher()
        {

           string[] talks = p.Sentences();


            foreach (string i in talks)
            {
               
                Console.WriteLine(i);

                Thread.Sleep(4000);
              
            }
        }

        public void NextSene()
        {
            string Period = ".";
            string Period2 = ".";
            string Period3 = "...................................................................................................................";
            int Intervel = 300;
            for (int i = 0; i < 200; i++)
            {
               

                Console.WriteLine(Period);
                if (Period.Length <  Console.WindowWidth)
                {
                    Period = Period + (Period2);
                }
               
                if (Intervel >= 20)
                {
                    Intervel = Intervel - 10;
                }
                

                Thread.Sleep(Intervel);
            }
           
        }

        public void DialogIntervel()
        {
            int time = 333;
            Thread.Sleep(2000);
           // if (Thread.Sleep(2000) = 333)
            {

            }

        }

    }
}

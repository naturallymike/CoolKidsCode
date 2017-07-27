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
        bool IsSleeping;
        int StrLen;


      

        public void StringCruncher()
        {

           string[] talks = p.Sentences();


            foreach (string i in talks)
            {
                StrLen = i.Length;
                Console.WriteLine("\n"+i);               
                IsSleeping = true;
                DialogIntervel();
                Thread.Sleep(100* i.Length);
                IsSleeping = false;
            }
        }

        public void NextSene()
        {
            string Period = ".";
            string Period2 = ".";
            string Period3 = "...................................................................................................................";
            int Intervel = 300;

            // Loop for making dots on the screen when changing scens
            for (int i = 0; i < 200; i++)
            {
               
                //Writes dots to screen
                Console.WriteLine(Period);

                // Makes dot line longer up till the end of the screen
                if (Period.Length <  Console.WindowWidth)
                {
                    Period = Period + (Period2);
                }

               // Makes dots print faster over time
                if (Intervel >= 20)
                {
                    Intervel = Intervel - 10;
                }
                
                //  Gives time space between printing dots
                Thread.Sleep(Intervel);
            }
           
        }

        public void DialogIntervel()
        {
            
            if (IsSleeping == true)
            {
                for (int i =0; i < StrLen; i++)
                {
                    Console.Write(".");
                    Thread.Sleep((100 * StrLen) / StrLen);
                }
                
            }

        }

    }
}

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
        int strInterval;


      

        public void StringCruncher()
        {

           string[] talks = p.Sentences();


            foreach (string i in talks)
            {
                StrLen = i.Length;
                Console.WriteLine("\n"+i);               
                IsSleeping = true;
                strInterval = 100 * i.Length;
                DialogIntervel();
                Thread.Sleep(strInterval);
                IsSleeping = false;
            }
        }

        public void NextSene()
        {
            string Period = ".";
            string Period2 = ".";
    
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
        // Makes a dotted line after each statment made by the PCU's
        public void DialogIntervel()
        {
            
            if (IsSleeping == true)
            {
                for (int i =0; i < StrLen; i++)
                {
                    Console.Write(".");
                    Thread.Sleep((100 * StrLen) / StrLen);
                    strInterval = 0;
                }
                
            }

        }
        // This function needs parammeters to tell it where to put the information recieved from user
        public void GetInfo(int Location,out string Input)
        {
          
           string userInput = Console.ReadLine();
            Input = userInput;
        }


    }
}

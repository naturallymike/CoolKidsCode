using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SomethingAmazing.Strings;

namespace SomethingAmazing.Stories
{   
    class StoryLogic
    {
        

        Reply p = new Reply();
       

        // Issues with the foreach loop. I need to access the string arrays inside the logic loop but I am getting errors. 

        public void StringCruncher()
        {
            string[] StringNumber = null;

            p.Sentences(StringNumber);

            

            foreach (string i in StringNumber)
            {
               
                Console.WriteLine(i);

                Thread.Sleep(3000);
              
            }
        }
    }
}

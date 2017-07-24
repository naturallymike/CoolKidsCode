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

        

        public void StringCruncher()
        {
            string StringNumber = "Cats";

            p.Sentences(StringNumber);

            

            //foreach (string i in StringNumber)
            //{
               
            //    Console.WriteLine(i);

            //    Thread.Sleep(3000);
              
            //}
        }
    }
}

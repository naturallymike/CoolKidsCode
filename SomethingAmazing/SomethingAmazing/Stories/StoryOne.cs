using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SomethingAmazing.Things;

namespace SomethingAmazing.Stories
{
    class StoryOne
    {
        StoryLogic sl = new StoryLogic();
        Users u = new Users();
        Person User1Info = new Person();


        // I am thinking that this class is where all the story functins could be stored and created. Calling on StoryLogic for methods
        // and reply for text content and then finnaly a single function will be called in Main to start the process. But story design should
        // I think be in here in StoryOne.  Right now when I wrote this Intro is right below this text. But I think it should be moved to 
        // Reply instead. As should all textual or string objects.

        public static void Intro()
        {
            Console.WriteLine("This game was made by.....");

            Thread.Sleep(4000);

            Console.WriteLine("\n\nJUSTIN and.....");

            Thread.Sleep(2000);
            Console.WriteLine("MICHAEL MATHIS...");

            Thread.Sleep(3000);

            Console.WriteLine("\n\n\nBringing you....");

            Thread.Sleep(6000);

            Console.WriteLine("\n\n\n\n\n\n                                   .............HACKPHILLA.............. ");

            Thread.Sleep(2000);

            
        }
         

        // This is where I will start making and designing the story which will consist of calling methods and functions to Pull text and strings 
        //such as the first methdo getting the intro string and its containing method to corectly parse those strings into a nice intro.
        // And other methods to pull strings to lead you through a story. And then methods to pull string replys and to hopfully 
        //construct string sentences for convencing and fun talk bot characters for really fun interactions in an otherwise bland game platform.
        // aka the Consloe lol.  
        // So its going to be set up like this Main pulls first Main.Method1 > StoryOne.Method1 > StoryLogic.Method1 > Reply.StringArrays


        public void GameStory()
        {
           int  Location= 32;
           

            sl.GetInfo(Location, out string Input);
            string uName = Input;


            Console.WriteLine("Oh really {0} is it... Well {1} do you wanna play with me?", User1Info.Name, User1Info.Name);
            Console.ReadKey();

        }

    }
}

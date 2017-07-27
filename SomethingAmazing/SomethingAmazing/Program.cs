using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomethingAmazing.Stories;
using SomethingAmazing.Things;

namespace SomethingAmazing
{
    class Program
    {
        //We will loop the program components here, this shouldn't be much larger than 100 lines or whatever.
        static void Main(string[] args)
        {
            StoryLogic sl = new StoryLogic();
            Person p = new Person();
            StoryOne so = new StoryOne();


            StoryOne.Intro();
            
            sl.NextSene();

            sl.StringCruncher();

            so.GameStory();
        }
    }
} 

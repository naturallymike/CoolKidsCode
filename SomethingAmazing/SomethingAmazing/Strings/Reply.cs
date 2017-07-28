using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomethingAmazing.Stories;
using SomethingAmazing.Things;


namespace SomethingAmazing.Strings
{
    
    public class Reply
    {
        Users u = new Users();
        Person User1Info = new Person();

        public void Intro()
        {

        }


        // This method is for future TalkBots in the game. Each string in the array will have a sorting number, and certain numbers can go
        //together and some can't
        public void CharReplies( params string[] CharRe)
        { 
          //  List<string> CharRe = new List<string>();

           // List<string> CharRe = new List<string>(new string[11]);

            // string[] CharRe = new string[100];




            CharRe[0] = "Hello";
            CharRe[1] = "Hi";
            CharRe[2] = "You";
            CharRe[3] = "Me";
            CharRe[4] = "?";
            CharRe[5] = "";
            CharRe[6] = "";
            CharRe[7] = "";
            CharRe[8] = "";
            CharRe[9] = "";
            CharRe[10] = ""; 
         /*   CharRe[2] = "";
            CharRe[3] = "";
            CharRe[4] = "";
            CharRe[5] = "";
            CharRe[2] = "";
            CharRe[3] = "";
            CharRe[4] = "";
            CharRe[5] = ""; 
            CharRe[2] = "";
            CharRe[3] = "";
            CharRe[4] = "";
            CharRe[5] = "";
          */  
        }



        public string[] Sentences()
        {
           

            string[] talk = new string[11];        
            
            talk[0] = "(Little Girls) Who is he mom???";
            talk[1] = "(Mother).... I don't know sweetie.";
            talk[2] = "Is he sleeping?";
            talk[3] = "Yes. Stay here with him and make sure he doesn't leave. I am going to get some supplies, I will be a while";
            talk[4] = "''''BYE MOM''' BYE baby''''";
            talk[5] = "......................";
            talk[6] = "Lalal de de, la de da da. I wonder if you are really out??? What do you look like under here......";
            talk[7] = "Oh wow... so soooo wow. I wounder if you can feel anything???? ";
            talk[8] = "You have such nice hair mr.guy. But you don't feel my hands in it do you.... Can you feel your hands?";
            talk[9] = "What about here or here. how about right here giggles... Looks different now...Hmmm bites lip a little. Guys are strange," +
                       " but I like you mr.guy";
            talk[10] = "HO M...Ggggg You moved.. Hey YOU! Are you awake now???....Your eyes are open!! Heyyy I'm Kira... What is you name?" +
                "\n Enter your Name \n";


            

            return (talk);
        }
    }
}

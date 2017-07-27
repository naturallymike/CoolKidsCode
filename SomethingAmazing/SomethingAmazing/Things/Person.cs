using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingAmazing.Things
{
    class Person: Living
    {
        Users u = new Users();
        

        //class fields or members
        public string Name;
        public int? Age = null;
        public int Energy = 0;
        public int Temp = 97;
        public string Gender = null;
        //This could be used to make alien classes or varied humans
        public string BioClass = "Human";
        // This can be used to change clothes, and could be made so that the first value 1 in 123 would be a hat type and 2 in 123 would be
        // a shirt type and so on. The value could be 538 meaning the fith hat and the third shirt and eighth pants. It is set to string 
        //but could be an INT
        public string Clothes = "SetOne";
        // Same as clothes for body type
        public int BodyType = 000;
        // This value is used for characters buying power, and influince.
        public int SocialStat = 0;
        //This value is used for characters family link and housing area.
        public int ClanLink = 0;
        // What the character is good at. ie Building houses. Hunting etc ????
        public int Skills = 0;
        // This value is where the cpu is used in the game. Say building a house. Or delivers a message to someoneon on day 10020
        public int Implamentation;
        // Array is used to store character driving forces
        public int[] Desires;
        // This is used to take the currant state of character and this could alter the state of the more permanet field "Desire".
        // this could happen due to time of a currant state, thus changing the long term desires. Such as cold too long so builds warm house
        public int[] EmotionalState;
        


        //class constructor
        public Person()
        {
        }

        //class methods
        public void Eat()
        {
            Energy += 1;
        }
        public void BodyTempUp()
        {
            Temp += 1;
        }
        public void BodyTempDown()
        {
            Temp -= 1;
        }
    }
}

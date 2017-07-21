using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingAmazing.Things
{
    class Person: Thing
    {
        //class fields or members
        string Name = null;
        int? Age = null;
        int Energy = 0;
        int Temp = 97;
        string Gender = null;
        //This could be used to make alien classes or varied humans
        string BioClass = "Human";
        // This can be used to change clothes, and could be made so that the first value 1 in 123 would be a hat type and 2 in 123 would be
        // a shirt type and so on. The value could be 538 meaning the fith hat and the third shirt and eighth pants. It is set to string 
        //but could be an INT
        string Clothes = "SetOne";
        // Same as clothes for body type
        int BodyType = 000;
        // This value is used for characters buying power, and influince.
        int SocialStat = 0;
        //This value is used for characters family link and housing area.
        int ClanLink = 0;
        // What the character is good at. ie Building houses. Hunting etc ????
        int Skills = 0;
        // This value is where the cpu is used in the game. Say building a house. Or delivers a message to someoneon on day 10020
        int Implamentation;
        // Array is used to store character driving forces
        int[] Desires;
        // This is used to take the currant state of character and this could alter the state of the more permanet field "Desire".
        // this could happen due to time of a currant state, thus changing the long term desires. Such as cold too long so builds warm house
        int[] EmotionalState;




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

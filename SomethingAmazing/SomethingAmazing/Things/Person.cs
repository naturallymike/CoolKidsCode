using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingAmazing.Things
{
    class Person: Thing
    {
        //class fields
        string Name = null;
        int? Age = null;
        int Energy = 0;
        int Temp = 97;

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

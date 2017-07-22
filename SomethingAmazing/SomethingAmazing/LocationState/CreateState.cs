using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingAmazing.LocationState
{
    class CreateState
    {
        //This class may be unnessacery*(lol) 
        // But it is intended to assign a newly created object to one of the Obj[] list numbers.

        bool   StartMake = false; // Set by the runtime game engine to create an object
        int    ObjType;
        int    ObjColor;
        int    ObjSize;
        int    ObjLocation;
        int    ObjMass;
        int?   ObjVolume = null; // This can be null and a defult will be used. The same for Mass, Color, Size, etc.

     

       

        

        // Making the object and assigning a value that is readable to the porgram
        public void Make()
        {


            if (StartMake == true && ObjType != null) // Just an example of how it is allowed to create a object whe make is called
            {
                

            }
        }
    }
   
}

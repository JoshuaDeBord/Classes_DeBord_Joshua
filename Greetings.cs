using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_DeBord_Joshua
{
    class Greetings
    {

        public void Welcome()
        {
            Console.WriteLine("Hello Adventurer!, Welcome!"); //sends to the console "Hello! adventurer!"
        }

        public void Hello(string name)
        {
            Console.WriteLine($"{name}, thank you for joining us!"); //thanks the user in the console for joining us
        }



    }
}

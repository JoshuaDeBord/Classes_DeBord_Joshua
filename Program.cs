using System;

namespace Classes_DeBord_Joshua
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates and initilze a greetings objects
            Greetings greetings = new Greetings();
            greetings.Welcome();

            Console.WriteLine("What is your name?"); //asks the user to input their name into the console
            string userName = Console.ReadLine();

            greetings.Hello("Joshua");
          


        }
    }
}

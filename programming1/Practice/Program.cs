using System;
using FSPG;


/////////////////////////////////////////////////////////////////////////////
// TODO:    BEFORE YOU WRITE ANY CODE: 
//          Read the Instructions.pdf file.
//          Run the example.exe to see how this program will behave.
//          Read through all of the TODOs. This will give you an overview
//          of how the program will be put together.

namespace Practice
{
    class Program
    {
        static string[] Greetings = { "Hello there!", "Welcome to the practice!", "Hi, user!",
                                "Hey, I am a program.", "You're running the best program ever!" };

        static void Main(string[] args)
        {
            // TODO: Display a random string from the Greetings array.
            Random rnd = new Random();
            int x = rnd.Next(0, 4);
            Console.WriteLine(Greetings[x]);

            Console.ReadLine();
            Console.Clear();

            // TODO: Ask the user for a positive number and then print the square of that number.
            //       Make sure your progarm does not crash if the user enters bad input.
            //       Make sure the user can keep entering input until they enter good input.
            int number;
            Console.WriteLine("Please input a positive number: ");
            string input = Console.ReadLine();
            Int32.TryParse(input, out number);
            Console.WriteLine(number * 2);


            Console.ReadLine();
            Console.Clear();

            // TODO: Create an array of doubles. Use a random number (in the range of 3 to 6) for the size.
            //       For each element of the array, ask the user to enter a value and store
            //       it in the array. The input does not have to be error checked.

            // TODO: Call the FindAverage method passing in the array of doubles and display
            //       the return value to the screen.


            Console.ReadLine();
        }

        // TODO: Write a method called FindAverage that takes an array of doubles and returns a double
        //       Don't forget to mark the method as static.

        // TODO: In the FindAverage method compute the average (the sum of all values divided by the number of values)
        //       of the values in the array parameter and return it.

    }
}

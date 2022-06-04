using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSPG1
{
    class Submission
    {

        // Given a string, invoke the Parse() method of the int class to convert the string 
        // to an integer. Return the integer
        public static int Test3(string input)
        {
            int newInput = Int32.Parse(input);
            return newInput;
        }

        // Given a string, invoke the Parse() method of the sbyte class to convert the string 
        // to a signed byte. Return the signed byte
        public static sbyte Test4(string input)
        {
            sbyte newInput = SByte.Parse(input);
            return newInput;
        }

        // Given a string, invoke the Parse() method of the double class to convert the string 
        // to a double Return the double
        public static double Test5(string input)
        {
            double newInput = Double.Parse(input);
            return newInput;
        }

        // Given a string, invoke the Parse() method of the ushort class to convert the string
        // to a unsigned short. Return the unsigned short
        public static ushort Test6(string input)
        {
            ushort newInput = UInt16.Parse(input);
            return newInput;
        }

        // Given a string, invoke the Parse() method of the float class to convert the string 
        // to a float. Return the float
        public static float Test7(string input)
        {
            float newInput = Single.Parse(input);
            return newInput;
        }

        // Given a string, invoke the Parse() method of the uint class to convert the string
        // to an unsigned integer. Return the unsigned integer
        public static uint Test8(string input)
        {
            uint newInput = UInt32.Parse(input);
            return newInput;
        }

        // Given a string, invoke the Parse() method of the short class to convert the string
        // to a short. Return the short
        public static short Test9(string input)
        {
            short newInput = Int16.Parse(input);
            return newInput;
        }

        // Given a string, invoke the Parse() method of the ulong class to convert the string
        // to an unsigned long. Return the unsigned long
        public static ulong Test10(string input)
        {
            ulong newInput = UInt64.Parse(input);
            return newInput;
        }
    }
}

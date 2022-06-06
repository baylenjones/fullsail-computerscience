using FS_Supplemental;
using Tester;

namespace FSPG1
{
    class Submission
    {
        /*
         * This lab is NOT interactive - that means there should be no 
         * calls to the Console class (no Write/WriteLine/ReadLine/ReadKey)
         * 
        */

        // Given two ints, num1 and num2, determine if num1 is a multiple of num2. 
        // If it is a multiple return true, otherwise, return false.
        public static bool Test1(int num1, int num2)
        {
            if (num1 % num2 != 0)
            {
                return false;
            }
            else {
                return true;
            }
        }

        // Given two doubles, fahrenheit and celsius, determine if they are equal temperatures. 
        // The formula to convert Fahrenheit to Celsius is:
        // Celsius = (fahrenheit - 32.0) * (5.0/9.0)
        // The formula to convert Celsius to Fahrenheit to Celsius is:
        // Fahrenheit = (celsius* 9.0 / 5.0) + 32.0
        public static bool Test2(double fahrenheit, double celsius)
        {
            double result = (fahrenheit - 32.0) * (5.0 / 9.0);
            if(result == celsius)
            {
                return true;
            }
            else {
            return false;
            }
        }

        // Given the grade variable, which indicates a student's numeric grade, 
        // determine which letter grade they should receive. Return the proper 
        // letter (char) as the result of this test. Do not worry about rounding 
        // the grade. Use the following table to indicate which letter corresponds 
        // to provided grades.
        // Use if and else-if for Test3
        // Remember only one return statement is allowed
        //  >= 90 and <= 100 	'A'
        //  >= 80 and< 90 	    'B'
        //  >= 73 and< 80    	'C'
        //  >= 70 and< 73 	    'D'
        //  >= 0 and< 70 	    'F'
        //  < 0 or> 100 	    '?'

        public static char Test3(double grade)
        {
            if(grade >= 90 && grade <= 100) {
                return 'A';
            }
            else if(grade >= 80 && grade < 90)
            {
                return 'B';
            }
            else if (grade >= 73 && grade < 80)
            {
                return 'C';
            }
            else if (grade >= 70 && grade < 73)
            {
                return 'D';
            }
            else if (grade >= 0 && grade < 70)
            {
                return 'F';
            }
            else
            {
                return '?';
            }
        }

        // Given two doubles (num1 and num2) and a MathOperator, an enum,
        // value that indicates a math operation, perform the appropriate 
        // math operation on the two numbers and return the result. The 
        // MathOperator enum has already been defined (so you do not need 
        // to redefine it). It's values are: Add, Subtract, Multiply, Divide
        // Use a switch for Test4
        // Remember only one return statement is allowed
        public static double Test4(double number1, double number2, MathOperator op)
        {
            switch (op)
            {
                case MathOperator.Add:
                    return (number1 + number2);
                    break;
                case MathOperator.Subtract:
                    return (number1 - number2);
                    break;
                case MathOperator.Multiply:
                    return (number1 * number2);
                    break;
                case MathOperator.Divide:
                    return (number1 / number2);
                    break;

            }
            return 0;
        }

        // Given an int, speed, and the following decision table, determine 
        // what action should be taken.Return the number that represents the 
        // action from the table
        // speed <= 5               0 - verbal warning
        // speed > 5 and <= 10      1 - written warning
        // speed > 10 and <= 25     2 - citation
        // speed > 25               3 - take into custody
        // You cannot use multiple return statements in this method

        public static int Test5(int speed)
        {
            if (speed <= 5)
            {
                return 0;
            }
            else if (speed > 5 && speed <= 10)
            {
                return 1;
            }
            else if (speed > 10 && speed <= 25)
            {
                return 2;
            }
            else if (speed > 25)
            {
                return 3;
            }
            return 0;
        }

        // Given two Point objects, determine if they two Point objects 
        // are equal. The Point class provides an 'Equals' method that 
        // can be used to determine if a Point is equal to a second point. 
        // The Equals method signature is:
        // bool Equals(object obj)
        public static bool Test6(Point p1, Point p2)
        {
            return Equals(p1, p2);
        }

        // Given three doubles that represent the cost of an item, the         
        // applicable tax rate for the item and cash on hand, determine 
        // if cash on hands will cover the cost of the item. Return true 
        // if the item can be purchased, otherwise return false
        public static bool Test7(double price, double taxRate, double cashOnHand)
        {
            double result = (price + (price * taxRate));
            if(result > cashOnHand)
            {
                return false;
            } else
            {
                return true;
            }
        }

        // Given a distance in miles and a distance in kilometers, determine
        // which is the greater distance. Return the value of the greater 
        // distance. Use the conversion factor:
        // 1km = 0.621 miles (1 mile = 1.609km)
        public static double Test8(double miles, double kilometers)
        {
            double result = (miles * 1.609);
            if (result < kilometers)
            {
                return kilometers;
            } else
            {
                return miles;
            }
        }
    }
}

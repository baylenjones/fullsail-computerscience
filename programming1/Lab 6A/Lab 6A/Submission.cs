using System;
using System.Diagnostics.Contracts;
using Tester;

namespace FSPG1
{
    class Submission
    {
        /*
         * This lab is NOT interactive - that means there should be no 
         * calls to the Console class (no Write/WriteLine/ReadLine/ReadKey)
         * 
         * You cannot use multiple return statements any of these methods. 
         * Additionally the use of var is not permitted
         * 
        */

        // Test 1 – Convert char array to int array
        // Given an array of char, phrase, convert each element to an
        // equivalent int value and place in an int array.
        // Return the int array
        public static int[] Test1(char[] phrase)
        {
            int[] results = new int[phrase.Length];
            for (int i = 0; i < phrase.Length; i++)
            {
                results[i] = Convert.ToInt32(phrase[i]);
            }
            return results;
        }

        // Test 2 - Array statistics
        // Given an array of double, data, find the smallest element, 
        // the largest element and the numeric mean (average). Store the 
        // results in an array (in that order: smallest, largest, mean).
        // Return the array
        public static double[] Test2(double[] data)
        {
            double[] results = new double[3];
            double total = 0;
            double numCount = 0;

            Array.Sort(data);
            results[0] = data[0];
            results[1] = data[data.Length - 1];

            foreach (double x in data)
            {
                total += x;
                numCount += 1;
            }

            results[2] = (total / numCount);

            return results;
        }

        // Test 3 - Normalize an array (of double)
        // Given an array of double, numbers, normalize the array. To 
        // normalize an array:
        // 1) Find the largest element stored in the array
        // 2) Divide each element in the array by the largest value
        //    and replace each array element with the result of the 
        //    division.
        // Since the array's contents are being modified, there is 
        // nothing to return
        public static void Test3(double[] numbers)
        {
            double max = numbers[0];

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] /= max;
            }
        }

        // Test 4 - Uniqueness
        // Given an array of string, names, verify that each name is unique
        // mean that none of the names are duplicated within the array.
        // If the array is unique, return true; otherwise, return false
        public static bool Test4(string [] names)
        {
            string Unique = "";
            int count = 0;
            bool result = true;

            for (int x = 0; x < names.Length; x++)
            {
                Unique = names[x];
                count = 0;

                for (int i = 0; i < names.Length; i++)
                {
                    if (Unique == names[i])
                    {
                        count += 1;
                    }
                }

                if(count >= 2)
                {
                    result = false;
                }

            }

            return result;
        }

        // Test 5 - Acronym
        // Given an array of string, words, create a string that is the 
        // acronym (first letter of each word). Return the string
        public static string Test5(string [] words)
        {
            string[] acronym = new string[words.Length];

            for(int x = 0; x < words.Length; x++)
            {
                acronym[x] = words[x].Substring(0, 1);
            }

            string result = string.Join("", acronym);
            return result;
        }

        // Test 6 - Array reverse
        // Given a char array, letters, create another array that has the
        // same elements but in reverse order. Return the array
        // 
        // You are not allowed to use Array.Reverse (or any existing
        // method) to reverse the array
        //
        public static char[] Test6(char[] letters)
        {
            char[] reversed = new char[letters.Length];
            int j = 0;

            for(int i = letters.Length - 1; i >= 0; i--)
            {
                reversed[j] = letters[i];
                j += 1;
            }
            return reversed;
        }

        // Test 7 - Transpose array
        // Given a 2-Dimension array of int, table, create a new array that 
        // 'transposes' the original array. Transposing means that each row 
        // in the original array will be a column in the new array and each
        // column in the original array will be a row in the new array.
        // For example, given
        //   4   3   1   5
        //   2   7   0   8
        //
        // The transposed array would be
        //   4   2
        //   3   7
        //   1   0
        //   5   8
        //
        public static int[,] Test7(int [,] table)
        {
            int[,] transposed = new int[table.GetLength(1),table.GetLength(0)];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {

                    transposed[j, i] = table[i, j];
                }
            }

            return transposed;
        }

        // Test 8 – Return a 2D array
        // Given three arrays of the same type (int) and size, combine the 
        // arrays into a single 2D array. Return the 2D array
        // NOTE: This solution requires a single loop (not three)
        // 
        public static int [,] Test8(int [] mins, int [] maxes, int [] seeds)
        {
            int[,] results = new int[3, maxes.Length];

            for(int x = 0; x < mins.Length; x++)
            {
                results[0, x] = mins[x];
                results[1, x] = maxes[x];
                results[2, x] = seeds[x];
            }
            return results;
        }

        // Test 9 – Convert int array to char array
        // Given an array of int, ascii, convert each element to an
        // equivalent char value and place in a char array.
        // Return the char array
        public static char[] Test9(int[] ascii)
        {
            char[] results = new char[ascii.Length];

            for(int x = 0; x < ascii.Length; x++)
            {
                results[x] = (char)ascii[x];
            }
            return results;
        }

        // Test 10 – Modify an existing array
        // Given an array of char (all uppercase), modify the array so
        // that every other element will be lowercase (even indexes are 
        // upper, odd indexes are lower)
        public static void Test10(char[] word)
        {
            for(int x = 1; x < word.Length; x += 2)
            {
                word[x] = Char.ToLower(word[x]);
            }
        }
    }
}

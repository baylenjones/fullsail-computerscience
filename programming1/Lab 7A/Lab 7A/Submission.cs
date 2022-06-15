using System;
using System.Text;
using Lab_7A;

namespace FSPG1
{
    public class Submission
    {
        public static StringBuilder Test1(string [] names)
        {
            StringBuilder sb = new StringBuilder(names.Length);

            for(int i = 0; i < names.Length; i++)
            {
                sb.Append(names[i], 0, 1);
            }
            return sb;
        }

        public class Circle
        {
            float xPos;
            float yPos;
            float Radius;

            public Circle(float x, float y, float radius)
            {
                x = xPos;
                y = yPos;
                radius = Radius;
            }

            public float GetX()
            {
                return xPos;
            }

            public float GetY()
            {
                return yPos;
            }

            public float GetRadius()
            {
                return Radius;
            }
        }
        public static object Test2(float x, float y, float radius)
        {
            Circle c1 = new Circle(x, y, radius);
            return c1;
        }

        public static object Test3(float x, float y, float radius)
        {
            return null;
        }

        public static object Test4(float x, float y, float radius)
        {
            return null;
        }

        public static object Test5(float x, float y, float radius)
        {
            return null;
        }

        public static int Test6(string str1, string str2, bool ignoreCase)
        {
            return 0;
        }

        public static string Test7(sbyte offset, string message)
        {
            return null;
        }

        public static string Test8(sbyte offset, string message)
        {
            return null;
        }
    }
}

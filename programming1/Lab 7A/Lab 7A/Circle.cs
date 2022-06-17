using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7A
{
    public class Circle
    {
        public float mX;
        public float mY;
        public float mRadius;
        public float Area;
        public float Circumference;
        public Circle(float x, float y, float radius)
        {
            this.mX = x;
            this.mY = y;
            this.mRadius = radius;
            this.Area = Convert.ToSingle(Math.PI * Math.Pow(radius, 2));
            this.Circumference = (float)(2 * Math.PI * radius);
        }

        public float GetX()
        {
            return mX;
        }

        public void SetX(float x)
        {
            mX = x;
        }

        public float GetY()
        {
            return mY;
        }

        public void SetY(float y)
        {
            mY = y;
        }
        public float GetRadius()
        {
            return mRadius;
        }

        public void SetRadius(float radius)
        {
            mRadius = radius;
        }

        public float GetArea()
        {
            return Area;
        }

        public bool Contains(float px, float py)
        {
            float z = (px - mX) * (py - mX) + (py - mY) * (py - mY);

            bool results;
            if ( z <= mRadius * mRadius)
            {
                results = true;
            }
            else
            {
                results = false;
            }
            return results;
        }

        public float GetCircumference()
        {
            return Circumference;
        }

        public static StringBuilder acronym(string[] names)

        {

            StringBuilder str = new StringBuilder();

            for (int i = 0; i < names.Length; i++)
            {
                str.Append(names[i][0]);
            }

            return str;

        }

    }
}

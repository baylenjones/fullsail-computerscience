using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
    public class Student
    {
        // Add member fields here

        string lastname;
        string firstname;
        int ID;

        // Add default and overloaded constructors here

        public Student()
        {
            this.lastname = "";
            this.firstname = "";
            this.ID = 1000000;
        }

        public Student(string last, string first, int id)
        {
            this.lastname = last;
            this.firstname = first;
            this.ID = id;
        }
        // add Getters and Setters here

        public string GetFirstName()
        {
            return this.firstname;
        }

        public string GetLastName()
        {
            return this.lastname;
        }

        public int GetIDNumber()
        {
            return this.ID;
        }

        public void SetFirstName(string x)
        {
            this.firstname = x;
        }

        public void SetLastName(string x)
        {
            this.lastname = x;
        }

        public void SetIDNumber(int x)
        {
            this.ID = x;
        }





















/******************************************************************************************************
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                      do not modify any of the following code                                        *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
******************************************************************************************************/
        public override string ToString()
        {
            return "ID #: " + GetIDNumber() + "\tName: " + GetLastName() + ", " + GetFirstName();
        }

        public override bool Equals(object obj)
        {
            bool same = true;
            Student s2 = (Student)obj;
            if (this.GetLastName() != s2.GetLastName() || this.GetFirstName() != s2.GetFirstName() || this.GetIDNumber() != s2.GetIDNumber())
            {
                same = false;
            }
            return same;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
    public class Submission
    {
        public static Student[] enrollment = new Student[0];

        public static Student Test1(string last, string first, int idNo)
        {
            Student student = new Student(last,first, idNo);
            return student;
        }

        public static Student Test2()
        {
            Student student = new Student();
            return student;
        }

        public static bool Test3(Student enrolled)
        {
            for(int x = 0; x < enrollment.Length; x++)
            {
                if (enrollment[x] == null)
                {
                    enrollment[x] = enrolled;
                    return true;
                }
            }
            return false;
        }

        public static bool Test4(int idNumber)
        {
            for(int x = 0; x < enrollment.Length; x++)
            {
                if (enrollment[x] != null && enrollment[x].GetIDNumber() == idNumber)
                {
                    enrollment[x] = null;
                    return true;
                }
            }
            return false;
        }

        public static Student Test5(int idNumber)
        {
            for(int x = 0; x < enrollment.Length; x++)
            {
                if(enrollment[x] != null && enrollment[x].GetIDNumber() == idNumber)
                {
                    return enrollment[x];
                }
            }
            return null;
        }
    }
}

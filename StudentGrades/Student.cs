using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    class Student
    {
        public string name;
        public string subject;
        public double grade;

        public Student(string cName, string cSubject, double cGrade)
        {
            name = cName;
            subject = cSubject;
            grade = cGrade;
        }

        //RETURN WHETHER A STUDENT HAS HONOURS OR NOT
        public bool HasHonours()
        {
            if(grade >= 3.5)
            {
                return true;
            }
            return false;
        }

    }
}

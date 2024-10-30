using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        public string University;
        public string Specialty;
        public int Year;
        public int Rating1;
        public int Rating2;
        public int Rating3;
        public bool Scholarship;

        public double CalculateAverageGrade()
        {
            double sum = Rating1 + Rating2 + Rating3;
            return sum / 3;
        }

    }
}

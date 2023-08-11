using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Model
{
    internal class Student
    {
        private int _rollno;
        private string _name;
        private double _cgpa;
        public int Roll { get { return _rollno; } set { _rollno = ValidateRoll(value); } }

        private int ValidateRoll(int value)
        {
            if (value < 1)
                return 0;
            else
                return value;
        }
        public string Name { get { return _name; } set { _name = ValidateName(value); } }

        private string ValidateName(string value)
        {
            if (value.Length< 5)
                return " ";
            else
                return value;

        }
        public double Cgpa { get { return _cgpa; } set { _cgpa = ValidateCgpa(value); } }

        private double ValidateCgpa(double value)
        {
            if (value < 1)
                return 1;
            else if (value > 10)
                return 10;
            else
                return value;
        }
        public double percentage()
        {
            return Cgpa * 10 - 5;
        }
    }
}

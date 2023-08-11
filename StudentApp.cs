using StudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            SetStudentDetails(10,"Shreenidhi", 9.9, student1);
            PrintDetails(student1);
            Student student2 = new Student();
            SetStudentDetails(11, "Shre", 10.9, student2);
            PrintDetails(student2);
        }

        private static void PrintDetails(Student stdnt)
        {
            Console.WriteLine("Roll: " + stdnt.Roll);
            Console.WriteLine("Name: " + stdnt.Name);
            Console.WriteLine("CGPA: " + stdnt.Cgpa);
            Console.WriteLine("Percentage: " + stdnt.percentage());
            Console.WriteLine(" --------------------------------- ");
        }

        private static void SetStudentDetails(int v1, string v2, double v3,Student st)
        {
            st.Roll = v1;
            st.Name = v2;
            st.Cgpa = v3;
        }

    }
}

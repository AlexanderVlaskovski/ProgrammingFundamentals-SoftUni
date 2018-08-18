using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Student
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrade { get { return Grades.Average(); } }
    }

    class Program
    {
        static void Main()
        {
            int studentCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < studentCount; i++)
            {



                Student student = new Student();

                List<string> studentsInfo = Console.ReadLine().Split().ToList();

                student.Name = studentsInfo[0];
                studentsInfo.RemoveAt(0);
                student.Grades = studentsInfo.Select(double.Parse).ToList();
                students.Add(student);
            }

            foreach (var person in students.Where(x => x.AverageGrade >=5).OrderBy(x=>x.Name).ThenByDescending(x=>x.AverageGrade))
            {
                Console.WriteLine($"{person.Name} -> {person.AverageGrade:f2}");
            }


        }
    }
}

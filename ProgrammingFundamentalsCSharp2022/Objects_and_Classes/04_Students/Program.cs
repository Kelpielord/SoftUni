using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Students
{
    class Student 
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            this.FullName = firstName + " " + lastName;
        }
        public string FirstName { get; }
        public string LastName { get; }
        public double Grade { get; set; }
        public string FullName { get; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student); 
            }
            foreach (Student student in students.OrderByDescending(x => x.Grade).ThenBy(x => x.FullName))
            {
                Console.WriteLine($"{student.FullName}: {student.Grade:F2}");
            }
        }
    }
}

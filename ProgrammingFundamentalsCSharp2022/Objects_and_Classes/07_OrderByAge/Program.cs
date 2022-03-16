using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_OrderByAge
{
    class Student
    {
        public Student(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ').ToArray();
                if (tokens[0] == "End")
                {
                    break;
                }

                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);
                Student student = new Student(name, id, age);
                students.Add(id, student);

                ReplaceStudent(students, name, id, age);
            }

            PrintStudentsByAge(students);
        }

        private static void PrintStudentsByAge(Dictionary<string, Student> students)
        {
            foreach (var student in students.OrderBy(s => s.Value.Age))
            {
                Console.WriteLine($"{student.Value.Name} with ID: {student.Key} is {student.Value.Age} years old.");
            }
        }

        private static void ReplaceStudent(Dictionary<string, Student> students, string name, string id, int age)
        {
            if (students.ContainsKey(id))
            {
                students[id].Name = name;
                students[id].Age = age;
            }
        }
    }
}

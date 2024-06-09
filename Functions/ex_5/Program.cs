using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5
{
    public class Grades
    {
        public string Subject { get; set; }
        public int Grade { get; set; }
        public Grades(string subject, int grade) { Subject = subject; Grade = grade; }
        public override string ToString()
        {
            return $"Subject: {Subject}, Score: {Grade}";
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<Grades> grades { get; set; }
        public Student(string name, List<Grades> grades)
        {
            Name = name;
            this.grades = grades;
        }
        public double avgGrade()
        {
            return this.grades.Average(g => g.Grade);
        }
        public int maxGrade()
        {
            return this.grades.Max(m => m.Grade);
        }
        public override string ToString()
        {
            return $"Name: {Name}, Average Score: {avgGrade():F2}, Max Score: {maxGrade()}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student("Alice", new List<Grades>
                {
                    new Grades("Math", 95),
                    new Grades("English", 85),
                    new Grades("Science", 90)
                }),
                new Student("Bob", new List<Grades>
                {
                    new Grades("Math", 70),
                    new Grades("English", 60),
                    new Grades("Science", 99)
                }),
                new Student("Charlie", new List<Grades>
                {
                    new Grades("Math", 80),
                    new Grades("English", 90),
                    new Grades("Science", 85)
                })
            };
            var highest = students.OrderByDescending(st => st.maxGrade()).FirstOrDefault();
            var highestAvg = students.OrderByDescending(st => st.avgGrade()).FirstOrDefault();
            Console.WriteLine("Student with the highest average score:");
            Console.WriteLine(highestAvg);

            Console.WriteLine("\nStudent with the highest max score:");
            Console.WriteLine(highest);
        }
    }
}

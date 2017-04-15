namespace _04.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var gradesHolder = new List<double>();
            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var studentInfo = Console.ReadLine()
               .Split(' ')
               .ToList();

                for (int j = 1; j < studentInfo.Count; j++)
                {
                    gradesHolder.Add(double.Parse(studentInfo[j]));
                }

                var student = new Student
                {
                    Name = studentInfo[0],
                    Grades = gradesHolder,

                };

                students.Add(student);
                gradesHolder = new List<double>();
            }

            foreach (var item in students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                if (item.AverageGrade >= 5.00)
                {
                    Console.WriteLine(string.Join((""), ($"{item.Name} -> {item.AverageGrade:F2}")));

                }
            }
        }
    }
}




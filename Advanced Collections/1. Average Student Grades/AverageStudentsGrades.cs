﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Average_Student_Grades
{
    class AverageStudentsGrades
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var name = tokens[0];
                var grade = double.Parse(tokens[1]);

                if (!grades.ContainsKey(name))

                    grades[name] = new List<double>();
                grades[name].Add(grade);

            }

            foreach (var pair in grades)
            {
                var name = pair.Key;
                var studentGrades = pair.Value;
                var average = pair.Value.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrades)
                    Console.Write($"{grade:F2} ");

                Console.WriteLine($"(avg: {average:F2})");

            }
        }
    }
}

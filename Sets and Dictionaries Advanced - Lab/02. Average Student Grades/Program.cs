using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number of students
            int numberOfStudents = int.Parse(Console.ReadLine());

            //Use a dictionary (string  List<decimal>) 
            Dictionary<string, List<decimal>> gradesPerStudents = new Dictionary<string, List<decimal>>();

            //Check if the name exists before adding the grade. If it doesn’t, add it to the dictionary.
            CheckIfTheNameExists(numberOfStudents, gradesPerStudents);

            //Pass through all key-value pairs in the dictionary and print the results. You can use the -
            // - .Average() method to quickly calculate the average value from a list. 
            PrintAverageGradesPerStudents(gradesPerStudents);

        }

        private static void PrintAverageGradesPerStudents(Dictionary<string, List<decimal>> gradesPerStudents)
        {
            foreach (var student in gradesPerStudents)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(v => v.ToString("F2")))} (avg: {student.Value.Average():F2})");
            }
        }

        private static void CheckIfTheNameExists(int numberOfStudents, Dictionary<string, List<decimal>> gradesPerStudents)
        {
            for (int i = 0; i < numberOfStudents; i++)
            {
                //Reads a name of a student and his/her grades
                string[] studentsWithGrade = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string nameOfStudent = studentsWithGrade[0];
                decimal grade = decimal.Parse(studentsWithGrade[1]);

                if (gradesPerStudents.ContainsKey(nameOfStudent))
                {
                    gradesPerStudents[nameOfStudent].Add(grade);
                }
                else
                {
                    gradesPerStudents.Add(nameOfStudent, new List<decimal>() { grade });
                }
            }
        }
    }
}

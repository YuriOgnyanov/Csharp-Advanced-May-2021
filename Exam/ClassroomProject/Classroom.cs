using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> data;

        public int Capacity { get; set; }
        public int Count { get; set; }

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            data = new List<Student>();
        }

        public string RegisterStudent(Student student) 
        {
            string resultOfAdd = string.Empty;

            if (data.Count < this.Capacity)
            {
                data.Add(student);
                resultOfAdd = $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                resultOfAdd = "No seats in the classroom";
            }
            return resultOfAdd;
        }

        public string DismissStudent(string firstName, string lastName) 
        {
            string boolRemove = string.Empty;

            Student currStudent = data.Where(x => x.FirstName == firstName).FirstOrDefault(x => x.LastName == lastName);

            if (currStudent != null)
            {
                data.Remove(currStudent);
                boolRemove = $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                boolRemove = $"Student not found";
            }
            return boolRemove;
        }

        public string GetSubjectInfo(string subject) 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine("Students:");

            foreach (Student student in data)
            {
                sb.AppendLine($"{student.FirstName} {student.LastName}");
            }

            return sb.ToString().TrimEnd();
        }




    }
}

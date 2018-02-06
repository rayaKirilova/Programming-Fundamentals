﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor_Group
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Student> students = new SortedDictionary<string, Student>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of dates")
                {
                    break;
                }

                var tokens = input.Split(' ');
                string name = tokens[0];
                if (tokens.Length == 1)
                {
                    if (!students.ContainsKey(name))
                    {
                        Student newStudent = new Student()
                        {
                            Name = name,
                            Comments = new List<string>(),
                            Dates = new List<DateTime>()
                        };
                        students.Add(newStudent.Name, newStudent);
                    }
                    continue;
                }
                var dateTokens = tokens[1].Split(',').ToArray();

                List<DateTime> dates = new List<DateTime>();
                for (int i = 0; i < dateTokens.Length; i++)
                {
                    dates.Add(DateTime.ParseExact(dateTokens[i], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));
                }

                Student student = new Student()
                {
                    Name = name,
                    Dates = dates,
                    Comments = new List<string>()
                };

                if (students.ContainsKey(student.Name))
                {
                    students[student.Name].Dates.AddRange(student.Dates);
                }
                else
                {
                    students.Add(student.Name, student);
                }
            }

            while (true)
            {
                var commentAndStudent = Console.ReadLine();
                if (commentAndStudent == "end of comments")
                {
                    break;
                }
                var tokens = commentAndStudent.Split('-');
                if (tokens.Length <= 1)
                {
                    continue;
                }
                string name = tokens[0];
                string comment = tokens[1];

                if (students.ContainsKey(name))
                {
                    students[name].Comments.Add(comment);
                }
            }
        }
    }
}

using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook: BaseGradeBook
    {
        public string name;

        public GradeBookType Type { get; set; }

        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            this.name = name;
            this.Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            int student = 0;
            if (base.Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            else if (base.Students.Count >= 5)
            {
                for (int i = 0; i < Students.Count; i++)
                {
                    if (Students[i].AverageGrade == averageGrade)
                    {
                        student++;
                    }
                }
                if (student == Students.Count /5)
                {
                    return 'A';
                }
                else if (student > Students.Count / 5 || student < Students.Count * 0.4)
                {
                    return 'B';
                }
                else if (student > Students.Count * 0.4 || student < Students.Count * 0.6)
                {
                    return 'C';
                }
                else if (student > Students.Count * 0.6 || student < Students.Count * 0.8)
                {
                    return 'D';
                }
            }
            return 'F';
        }

        public override void CalculateStatistics()
        {
            if (base.Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students");
            }
            else if (base.Students.Count >= 5)
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name) 
        {
            if (base.Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students");
            }
            else if (base.Students.Count >= 5)
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}

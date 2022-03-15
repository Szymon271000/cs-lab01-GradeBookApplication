using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
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
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            double min = Students.Min(x => x.AverageGrade);
            double max = Students.Max(x => x.AverageGrade);
            double diff = max - min;
            double step = diff / 5;
            if(averageGrade >= 4 * step)
            {
                return 'A';
            }
            else if (averageGrade >= 3 * step)
            {
                return 'B';
            }
            else if (averageGrade >= 2 * step)
            {
                return 'C';
            }
            else if (averageGrade >= 1 * step)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
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

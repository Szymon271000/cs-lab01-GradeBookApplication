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

        public RankedGradeBook(string name) : base(name)
        {
            this.name = name;
            this.Type = GradeBookType.Ranked;
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

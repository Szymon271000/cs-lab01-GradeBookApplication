using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook: BaseGradeBook
    {
        public string name;

        public GradeBookType Type { get; set; }

        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            this.name = name;
            this.Type = GradeBookType.Standard;
        }
    }
}

using System;

namespace Courseboard.Data
{
    public class Course
    {
        public int CodeId { get; set; }
        public int TermId { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

    }
}

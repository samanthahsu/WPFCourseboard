using System;
using System.Collections.Generic;
using System.Text;

namespace Courseboard.Data
{
    public class Term
    {

        public int TermId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public string Notes { get; set; }
    }
}

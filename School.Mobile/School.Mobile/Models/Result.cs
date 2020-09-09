using System;
using System.Collections.Generic;
using System.Text;

namespace School.Mobile.Models
{
    public class Result
    {
        public int Id { get; set; }
        public int Arabic { get; set; }
        public int English { get; set; }
        public int Maths { get; set; }
        public int Sociology { get; set; }
        public double Total { get; set; }

        public string Success { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}

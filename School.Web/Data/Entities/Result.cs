using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Web.Data.Entities
{
    public class Result
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "ماده العربي")]
        public int Arabic { get; set; }


        [Required]
        [Display(Name = "ماده الانكليزيه")]
        public int English { get; set; }


        [Required]
        [Display(Name = "ماده الرياضيات")]
        public int Maths { get; set; }


        [Required]
        [Display(Name = "ماده الاجتماعيات")]
        public int Sociology { get; set; }


        [Required]
        [Display(Name = "المجموع")]
        public double Total { get; set; }




        [Required]
        [Display(Name = "حاله النتيجه")]
        public string Success { get; set; }

        [Required,Display(Name ="اسم الطالب")]
        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Web.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "اسم الطالب")]
        public string Name { get; set; }

      

        [Required]
        [Display(Name = "عمر الطالب")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "رقم موبايل ولي امر الطالب")]
        public string Mobile { get; set; }


        [Display(Name = "المرحله الدراسيه"),Required]
        public string StageSchool { get; set; }

        [Display(Name = "صوره البطاقه")]
        public string ImageUrl { get; set; }

        [NotMapped]
        public byte[] ImageArray { get; set; }
       


        [NotMapped]
        [Display(Name = "صوره ")]
        public IFormFile ImageFile { get; set; }

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImageUrl))
                {
                    return null;
                }

                return $"https://school-web.conveyor.cloud/{this.ImageUrl.Substring(1)}";

            }
        }



      


    }
}

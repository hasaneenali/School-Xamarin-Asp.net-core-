using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Web.Data.Entities
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "الاسم الثلاثي للمعلم")]
        public string Name { get; set; }


        [Required]
        [Display(Name = "عمر المعلم")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "رقم الموبايل")]
        public string Mobile { get; set; }

        [Display(Name = "صوره البطاقه")]
        public string ImageUrl { get; set; }


        [Required ]
        [Display(Name = " الاختصاص")]
        public int MaterialId { get; set; }


        [ForeignKey("MaterialId")]
        public  Material Material { get; set; }

        [NotMapped]
        public byte[] ImageArray { get; set; }
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

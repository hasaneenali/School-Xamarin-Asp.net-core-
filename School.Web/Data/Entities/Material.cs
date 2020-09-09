using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Web.Data.Entities
{
    public class Material
    {
        public int Id { get; set; }

        [Display(Name = " الرجاء ادخال اسم الماده"), Required(ErrorMessage = "اسم الماده")]
        public string Name { get; set; }


       // public ICollection<Teacher> Teachers { get; set; }
    }
}

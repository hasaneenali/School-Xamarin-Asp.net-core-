using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Web.Data.Entities
{
    public class Classe
    {
        public int Id { get; set; }

        [Display(Name = " الرجاء ادخال اسم الصف"), Required(ErrorMessage = "اسم الصف")]
        public string Name { get; set; }
    }
}

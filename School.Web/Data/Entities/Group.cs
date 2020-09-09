using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Web.Data.Entities
{
    public class Group
    {
        public int Id { get; set; }

        [Display(Name = " الرجاء ادخال اسم الشعبه"), Required(ErrorMessage = "اسم الشعبه")]
        public string Name { get; set; }
    }
}

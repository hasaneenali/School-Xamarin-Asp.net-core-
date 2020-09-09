using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace School.Mobile.Models
{
   public class Material
    {

        [Key]
       [AutoIncrement]
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}

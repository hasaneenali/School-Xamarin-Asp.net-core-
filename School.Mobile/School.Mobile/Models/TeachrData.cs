using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace School.Mobile.Models
{
   public class TeachrData
    {


        [Key]
       // [AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }

        public byte[] ImageArray { get; set; }

        //// [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        //  [JsonProperty("ImageFullPath")]
        public string ImageFullPath { get; set; }
    }
}

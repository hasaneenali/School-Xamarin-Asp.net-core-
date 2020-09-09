using Newtonsoft.Json;
using School.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common.Model
{
    public class Teacher
    {
        //[JsonProperty("Id")]
        public int Id { get; set; }


       // [JsonProperty("Name")]
        public string Name { get; set; }

      //  [JsonProperty("Age")]
        public int Age { get; set; }


       // [JsonProperty("Mobile")]
        public string Mobile { get; set; }



       //// [JsonProperty("MaterialId")]
        public int MaterialId { get; set; }

        public Material Material { get; set; }
        public byte[] ImageArray { get; set; }

       //// [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

      //  [JsonProperty("ImageFullPath")]
        public string ImageFullPath { get; set; }

    }
}

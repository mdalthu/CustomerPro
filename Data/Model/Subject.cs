using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CustomerPro.Data.Model
{
    [Serializable]
    public class Subject
    {
        [Key]

        public int Sub_Id { get; set; }
        public string Sub_Name { get; set; }

        [ForeignKey("Category")]
        public int Cat_Id { get; set; }
     [JsonIgnore]
        public Category Category { get; set; }


    }
}

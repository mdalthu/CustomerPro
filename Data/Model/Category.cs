using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CustomerPro.Data.Model
{
    [Serializable]
    public class Category
    {
     
        [Key]
        public int Cat_Id { get; set; }

        public string Cat_Name { get; set; }

      //  [JsonIgnore]
        public ICollection<Subject> Subject { get; set; }

    }
}

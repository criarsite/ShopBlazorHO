using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Shared
{
    public class Product
    {
        public int Id {get; set;}
        [MaxLength(100)]
        public string Title {get; set; }= string.Empty;
       //  [MaxLength(200)]
        public string Description {get; set;}= string.Empty;
        public string ImageUrl {get; set;}
        [Column(TypeName="decimal(10,2)")]
        public decimal Price {get; set;}
    }
}
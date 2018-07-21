using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WorkWithNowey.Models
{
    public class Class1
    {
        [Key]
        public int TestID { get; set; }
 
        public string Name { get; set; }
        public int Age { get; set; }
        public double FeeRate { get; set; }
    }
}
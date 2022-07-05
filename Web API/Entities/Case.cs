using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web_API.Entities
{
    public class Case
    {
        [Key]
        public int id { get; set; }

        public DateTime DateRep { get; set; }

        public string CountryExp { get; set; }

        public int ConfCases { get; set; }


    }
}

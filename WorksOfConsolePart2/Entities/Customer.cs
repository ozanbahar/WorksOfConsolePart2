using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorksOfConsolePart2.Entities
{
    internal class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

    }
}

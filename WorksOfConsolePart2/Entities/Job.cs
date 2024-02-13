﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorksOfConsolePart2.Entities
{
    internal class Job
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

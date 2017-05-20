﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarolineRibeiro.Models
{
    public class Subject
    {
        [Key]
        public long SubjId { get; set; }
        public string Name { get; set; }
    }
}
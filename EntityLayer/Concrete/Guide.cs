﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    public class Guide
    {
        [Key]
        public int GuideID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string InstagramUrl { get; set; }
        public bool Status { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac.Models
{
    public class Component
    {
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public string SerialNumber { get; set; }
        public string ItemNumber { get; set; }
        public string Batch {  get; set; }
        public ComponentType Type { get; set; }
        public int ServiceInterval { get; set; }
    }
}

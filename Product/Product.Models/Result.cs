﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Models
{
    public class Result<T>
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public T Data { get; set; }
    }
}
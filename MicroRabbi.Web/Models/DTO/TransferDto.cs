﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbi.Web.Models.DTO
{
    public class TransferDto
    {
        public int AccountFrom { get; set; }
        public int AccountTo { get; set; }
        public decimal TransferAmount { get; set; }
    }
}

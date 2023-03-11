﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _19T1021036.DomainModels;

namespace _19T1021036.Web.Models
{
    public class OrderSearchOutput : PaginationSearchOutput
    {
        public int Status { get; set; }
        public List<Order> Data { get; set; }
    }
}
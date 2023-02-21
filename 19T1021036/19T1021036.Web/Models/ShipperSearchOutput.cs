using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _19T1021036.DomainModels;
namespace _19T1021036.Web.Models
{
    public class ShipperSearchOutput : PaginationSearchOutput
    {
        public List<Shipper> Data { get; set; }
    }
}
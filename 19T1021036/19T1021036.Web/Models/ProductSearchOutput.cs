using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _19T1021036.DomainModels;

namespace _19T1021036.Web.Models
{
    public class ProductSearchOutput : PaginationSearchOutput
    {
        /// <summary>
        /// 
        /// </summary>
        public int SupplierID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CategoryID { get; set; }

        public List<Product> Data { get; set; }
    }
}
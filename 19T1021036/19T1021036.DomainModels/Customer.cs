﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19T1021036.DomainModels
{
    public class Customer
    {
        /// <summary>
        /// Id khách hàng
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Tên khách hàng
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Tên giao dịch
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Thành phố
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Mã bưu chính
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Quốc gia
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
    }
}

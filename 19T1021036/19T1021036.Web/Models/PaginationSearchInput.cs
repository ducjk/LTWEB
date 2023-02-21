﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19T1021036.Web.Models
{
    /// <summary>
    /// Lưu trữ thông tin đầu vào dùng để tìm kiếm, phân trang (đơn giản)
    /// </summary>
    public class PaginationSearchInput
    {
        /// <summary>
        /// Trang cần hiển thị
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// Số dòng trên mỗi trang
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// Giá trị cần tìm
        /// </summary>
        public string SearchValue { get; set; }
    }
}
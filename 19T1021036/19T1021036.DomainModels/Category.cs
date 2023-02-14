using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19T1021036.DomainModels
{
    public class Category
    {
        /// <summary>
        /// ID loại
        /// </summary>
        public int CategoryID { get; set; }

        /// <summary>
        /// Tên loại
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Mô tả
        /// </summary>
        public string Description { get; set; }

    }
}

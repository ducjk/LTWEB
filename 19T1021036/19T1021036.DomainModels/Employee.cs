using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19T1021036.DomainModels
{
    public class Employee
    {   
        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Tên
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Họ
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///Ngày sinh 
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// avatar
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
    }
}

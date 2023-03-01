using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using _19T1021036.DomainModels;

namespace _19T1021036.Web
{
    /// <summary>
    /// Lớp cung cấp các hàm chuyển đổi kiểu dữ liệu
    /// </summary>
    public static class Converter
    {
        /// <summary>
        /// Chuyển đổi ngày dạng dd/MM/yyyy sang giá trị ngày
        /// </summary>
        /// <param name="s"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static DateTime? DMYStringToDateTime(string s, string format = "dd/MM/yyyy")
        {
            try
            {
                return DateTime.ParseExact(s, format, CultureInfo.InvariantCulture);
            }
            catch
            {
                return null;
            }

        }

        public static UserAccount CookieToUserAccount(string value)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<UserAccount>(value);
        }
    }
}
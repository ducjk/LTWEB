using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _19T1021036.DomainModels;
using _19T1021036.DataLayers;
using System.Configuration;

namespace _19T1021036.BusinessLayers
{
    /// <summary>
    /// Cung cấp các chức năng xử lý dữ liệu chung liên quan đến:
    /// Quốc gia, Nhà cung cấp, Khách hàng, Người giao hàng, Nhân viên, Loại hàng.
    /// </summary>
    public static class CommonDataService
    {
        private static ICountryDAL countryDB;
        private static ICommonDAL<Supplier> supplierDB;
        private static ICommonDAL<Customer> customerDB;
        private static ICommonDAL<Shipper> shipperDB;
        private static ICommonDAL<Employee> employeeDB;
        private static ICommonDAL<Category> categoryDB;


        /// <summary>
        /// Ctor
        /// </summary>
        static CommonDataService()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            countryDB = new DataLayers.SQLServer.CountryDAL(connectionString);
            supplierDB = new DataLayers.SQLServer.SupplierDAL(connectionString);
            customerDB = new DataLayers.SQLServer.CustomerDAL(connectionString);
            shipperDB = new DataLayers.SQLServer.ShipperDAL(connectionString);
            employeeDB = new DataLayers.SQLServer.EmployeeDAL(connectionString);
            categoryDB = new DataLayers.SQLServer.CategoryDAL(connectionString);
        }

        #region Xử lý liên quan đến quốc gia

        public static List<Country> ListOfCountries()
        {
            return countryDB.List().ToList();
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _19T1021036.DomainModels;
using _19T1021036.BusinessLayers;


namespace _19T1021036.Web
{
    /// <summary>
    /// Danh sách quốc gia
    /// </summary>
    public static class SelectListHepler
    {
        public static List<SelectListItem> Countries()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() 
            { 
                Value = "",
                Text = "-- Chọn quốc gia --",
            });
            foreach (var item in CommonDataService.ListOfCountries())
            {
                list.Add(new SelectListItem()
                {
                    Value = item.CountryName,
                    Text = item.CountryName,
                });
            }    

            return list;
        }
    }
}
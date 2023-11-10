﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.ViewModel
{
    public class CityIndexViewModel
    {
        public IQueryable<Cities> Products { get; set; }
        public string Search { get; set; }
        public IEnumerable<CategoryWithCount> CatsWithCount { get; set; }
        public string Category { get; set; }
        public IEnumerable<SelectListItem> CatFilterItems
        {
            get
            {
                var allCats = CatsWithCount.Select(cc => new SelectListItem
                {
                    Value = cc.CategoryName,
                    Text = cc.CatNameWithCount
                });
                return allCats;
            }
        }
        public class CategoryWithCount
        {
            public int ProductCount { get; set; }
            public string CategoryName { get; set; }
            public string CatNameWithCount
            {
                get
                {
                    return CategoryName + " (" +
                    ProductCount.ToString() + ")";
                }
            }
        }

    }
}
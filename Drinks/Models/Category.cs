﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Drinks.Models

{
    public class Category
    {

        public string strCategory { get; set; }
    }

    public class Categories
    {
        [JsonProperty("drinks")]

        public  List<Category> CategoriesList { get; set; }
    }
}

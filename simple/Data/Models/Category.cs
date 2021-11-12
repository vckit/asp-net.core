using System;
using System.Collections.Generic;

namespace simple.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryTitle { get; set; }
        public string desc { get; set; }
        public List<Car> cars { get; set; }
    }
}

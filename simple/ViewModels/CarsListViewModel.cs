using System;
using simple.Data.Models;
using System.Collections.Generic;

namespace simple.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> GetAllCars { get; set; }

        public string currentCategory { get; set; }
    }
}

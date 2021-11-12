using System;
using System.Collections.Generic;
using simple.Data.Interfaces;
using simple.Data.Models;

namespace simple.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryTitle = "Электромобили", desc = "Современный вид транспорта"},
                    new Category{categoryTitle = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}

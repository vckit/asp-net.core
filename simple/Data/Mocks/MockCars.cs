using System;
using System.Collections.Generic;
using simple.Data.Interfaces;
using System.Linq;
using simple.Data.Models;

namespace simple.Data.Mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> AllCars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Tesla Model S",
                        shorDesc = "Защитим экология",
                        longDesc = "Современный, мощный, быстрый автомобиль",
                        img = "https://www.google.com/url?sa=i&url=https%3A%2F%2Finsideevs.ru%2Fnews%2F485752%2Ftesla-model-s-i-x-lishilis-svintsovo-kislotnykh-batarej%2F&psig=AOvVaw0L_XEXClagUHhCTtZNEooR&ust=1636831099651000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCJCg6pTFk_QCFQAAAAAdAAAAABAD",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Ford Fiestra",
                        shorDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fru.motor1.com%2Fnews%2F533526%2Fford-fiesta-facelift%2F&psig=AOvVaw0TKNRDdMwsMuDz8xcCkHzp&ust=1636831188608000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCIiv1L_Fk_QCFQAAAAAdAAAAABAF",
                        price = 11000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shorDesc = "Дерзский и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.bmw.ru%2Fru%2Fall-models%2Fm-series%2Fm3-sedan%2F2020%2Fbmw-3-series-sedan-m-automobiles-overview.html&psig=AOvVaw0KcEMsBSrocyAszSZzJtLd&ust=1636831258288000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCLDv8ODFk_QCFQAAAAAdAAAAABAD",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mercedes S Class",
                        shorDesc = "Уютный и большой",
                        longDesc = "Уютный автомобиль для городской жизни",
                        img = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.drom.ru%2Fcatalog%2Fmercedes-benz%2Fs-class%2Fg_2020_11998%2F&psig=AOvVaw0SlDZPq8RxE6Mq4aDaA0zZ&ust=1636831347284000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCNjhi4vGk_QCFQAAAAAdAAAAABA5",
                        price = 40000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shorDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://www.google.com/url?sa=i&url=https%3A%2F%2Frg.ru%2F2021%2F08%2F05%2Fnissan-obiavil-na-leaf-ogromnye-skidki-i-nikakogo-podvoha.html&psig=AOvVaw32Upx449PRlUH_rEi4CCcK&ust=1636831435066000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCPDa3bXGk_QCFQAAAAAdAAAAABAD",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                };
            }
        }
        public IEnumerable<Car> GetFavouriteCar { get; set; }

        public Car GetObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}

using simple.Data.Models;
using System.Collections.Generic;

namespace simple.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> AllCars { get; }
        IEnumerable<Car> GetFavouriteCar { get; set; }
        Car GetObjectCar(int carID);
    }
}

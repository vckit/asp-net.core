using simple.Data.Models;
using System.Collections.Generic;

namespace simple.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

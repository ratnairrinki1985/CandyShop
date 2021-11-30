using System;
using System.Collections.Generic;
using CandyShop.Models;

namespace CandyShop.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}

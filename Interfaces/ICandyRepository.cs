using System;
using System.Collections.Generic;
using CandyShop.Models;

namespace CandyShop.Interfaces
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> GetAllCandy { get; }
        IEnumerable<Candy> GetCandyOnSale { get; }
        Candy GetCandyById(int candyId);
    }
}

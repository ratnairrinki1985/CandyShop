using System;
using System.Collections.Generic;
using CandyShop.Models;

namespace CandyShop.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<Candy> CandyOnSale { get; set; }
    }
}

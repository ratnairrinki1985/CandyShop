using System;
using System.Collections.Generic;
using CandyShop.Models;

namespace CandyShop.ViewModels
{
    public class CandyListViewModel
    {
        public IEnumerable<Candy> candies { get; set; }
        public string CurrentCategory { get; set; }
    }
}

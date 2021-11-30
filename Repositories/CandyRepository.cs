using System;
using System.Collections.Generic;
using System.Linq;
using CandyShop.Data;
using CandyShop.Interfaces;
using CandyShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CandyShop.Repositories
{
    public class CandyRepository: ICandyRepository
    {
        private readonly AppDBContext _appDbContext;

        public CandyRepository(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Candy> GetAllCandy
        {
            get
            {
                return _appDbContext.Candies.Include(c => c.Category);
            }
        }

        public IEnumerable<Candy> GetCandyOnSale
        {
            get
            {
                return _appDbContext.Candies.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Candy GetCandyById(int candyId)
        {
            return _appDbContext.Candies.FirstOrDefault(c => c.CandyId == candyId);
        }
    }
}

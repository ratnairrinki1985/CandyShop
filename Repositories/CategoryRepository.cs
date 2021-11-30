using System;
using System.Collections.Generic;
using CandyShop.Data;
using CandyShop.Interfaces;
using CandyShop.Models;

namespace CandyShop.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        //public CategoryRepository()
        //{
        //}

        //IEnumerable<Category> ICategoryRepository.GetAllCategories => new List<Category>
        //{
        //    new Category
        //    {
        //        CategoryId=1,
        //        CategoryName="Hard Candy",
        //        CategoryDescription = "Delicous Hard Candy",
        //    },
        //    new Category
        //    {
        //        CategoryId=2,
        //        CategoryName="Chocolate Candy",
        //        CategoryDescription = "Scuptious Hard Candy",
        //    },
        //    new Category
        //    {
        //        CategoryId=3,
        //        CategoryName="Fruit Candy",
        //        CategoryDescription = "Sweet and Sour  Candy",
        //    }
        //};
        private readonly AppDBContext _appDbContext;

        public CategoryRepository(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;
    }
}

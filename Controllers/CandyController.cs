using System;
using CandyShop.Interfaces;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CandyShop.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
        }

        //public ViewResult List()
        //{
        //    ViewBag.CurrentCategory = "Bestsellers";
        //    return View(_candyRepository.GetAllCandy);
        //}

        public IActionResult List()
        {
            var candyListViewModel = new CandyListViewModel();
            candyListViewModel.candies = _candyRepository.GetAllCandy;
            candyListViewModel.CurrentCategory = "Bestsellers";
            return View(candyListViewModel);
        }

        public IActionResult Details(int id)
        {
            var candy = _candyRepository.GetCandyById(id);
            if (candy == null)
                return NotFound();
            else
                return View(candy);
        }
    }
}

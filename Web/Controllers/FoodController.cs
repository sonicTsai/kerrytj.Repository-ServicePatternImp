using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepositoryServicePatternDemo.Core.Services.Interfaces;

namespace Web.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            this._foodService = foodService;
        }

        public IActionResult Index()
        {
            var itemsSold = this._foodService.GetAllSold();
            return View(itemsSold);
        }
    }
}
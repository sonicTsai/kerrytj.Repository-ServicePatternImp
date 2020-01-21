using Microsoft.AspNetCore.Mvc;
using RepositoryServicePatternDemo.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class FinancialController : Controller
    {
        private readonly IFinancialsService _financialsService;

        public FinancialController(IFinancialsService financialsService)
        {
            this._financialsService = financialsService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
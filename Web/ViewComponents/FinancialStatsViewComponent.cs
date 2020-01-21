using Microsoft.AspNetCore.Mvc;
using RepositoryServicePatternDemo.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewComponents
{
    public class FinancialStatsViewComponent : ViewComponent
    {
        private readonly IFinancialsService _financialsService;

        public FinancialStatsViewComponent(IFinancialsService financialsService)
        {
            this._financialsService = financialsService;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var stats = this._financialsService.GetStats();
            return Task.FromResult<IViewComponentResult>(View(stats));
        }
    }
}

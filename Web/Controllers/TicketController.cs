using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepositoryServicePatternDemo.Core.Services.Interfaces;

namespace Web.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            this._ticketService = ticketService;
        }

        public IActionResult Index()
        {
            var tickets = this._ticketService.GetAllSold();
            return View(tickets);
        }
    }
}
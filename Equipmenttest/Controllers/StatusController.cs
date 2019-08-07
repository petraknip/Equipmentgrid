using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Equipmenttest.Models;
using Microsoft.AspNetCore.Mvc;

namespace Equipmenttest.Controllers
{
    public class StatusController : Controller
    {
        private readonly TestDataProvider provider;

        public StatusController(TestDataProvider provider)
        {
            this.provider = provider;
        }

        public IActionResult Index()
        {
            var data = provider.CreateRooms(4);

            return View(data);
        }

        public IActionResult Alternative()
        {
            return View();
        }
    }
}
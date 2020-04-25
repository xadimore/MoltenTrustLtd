using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace MoltenTrustLtd.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public IActionResult MarketData()
        {

            return View();
        }

        [HttpPost]
        public IActionResult MarketData(MarketData model)
        {

            return View();
        }

        [HttpGet]
        public IActionResult StockDetails()
        {

            return View();
        }

        [HttpPost]
        public IActionResult StockDetails(MarketData model)
        {

            return View();
        }


        [HttpGet]
        public IActionResult DailyPrice()
        {

            return View();
        }

        [HttpPost]
        public IActionResult DailyPrice(MarketData model)
        {

            return View();
        }

        

    }
}
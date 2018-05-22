﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context) {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _context.Items.ToList();
            return View("Index", model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }
    }
}

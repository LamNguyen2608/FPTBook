using FPTBook.Data;
using FPTBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FPTBook.Controllers
{
    public class AuthorController : Controller
    {
        private readonly AppDBContext _context;

        public AuthorController(AppDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Authors.ToList();
            return View(data);
        }

    }
}
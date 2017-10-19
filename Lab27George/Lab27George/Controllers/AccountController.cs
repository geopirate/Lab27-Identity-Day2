using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab27George.Models;

namespace Lab27George.Controllers
{
    public class AccountController : Controller
    {
        private readonly Lab27GeorgeContext _context;

        public AccountController(Lab27GeorgeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
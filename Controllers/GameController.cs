using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameDashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gameDashboard.Controllers
{
    public class GameController : Controller
    {
            private readonly GameDBContext _context;

            public GameController(GameDBContext context)
            {
                _context = context;
            }

            public async Task<IActionResult> Index()
            { 
            return View(await _context.Spil.ToListAsync());
            }
    }
}

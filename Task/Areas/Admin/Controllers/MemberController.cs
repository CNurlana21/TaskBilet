using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task.Dal;
using Task.Models;

namespace Task.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MemberController : Controller
    {
        private readonly AppDbContext _context;

        public MemberController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var members = await _context.Members
                .Include(x => x.Position)
                .ToListAsync();

            return View(members);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Positions = await _context.Position.ToListAsync();
            return View();
        }
      
       
    }
}

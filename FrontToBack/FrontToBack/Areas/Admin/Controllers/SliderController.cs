using FrontToBack.Data;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace FrontToBack.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
         public SliderController(AppDbContext context)
        {
            _context = context;
        }
      
       
        public async Task<IActionResult> Index()
        {
            IEnumerable<SliderInfo> sliders = await _context.SliderInfos.Where(m => m.SoftDeleted).ToListAsync();
            return View(sliders);
        }
    }
}

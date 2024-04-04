using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using XayDungWebAphone.ViewModels;

namespace XayDungWebAphone.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

        public IActionResult Index()
		{
            //var menus = await _context.Menus.Where(m => m.Hide == 0).OrderBy(m => m.Order).ToListAsync();
            //var cat_prods = await _context.Products.Where(m => m.Hide == 0 && m.IdCat == 1).OrderBy(m => m.Order).Take(3).ToListAsync();
            //var cat_cate_prods = await _context.Catologies.Where(m => m.IdCat == 2).FirstOrDefaultAsync();
            //var dog_prods = await _context.Products.Where(m => m.Hide == 0 && m.IdCat == 2).OrderBy(m => m.Order).Take(3).ToListAsync();
            //var dog_cate_prods = await _context.Catologies.Where(m => m.IdCat == 1).FirstOrDefaultAsync();
            //var viewModels = new HomeViewModel
            //{
            //    Menus = menus,

            //    Blogs = blogs,
            //    Sliders = slides,
            //    CatProds = cat_prods,
            //    DogProds = dog_prods,
            //    CatCateProds = cat_cate_prods,
            //    DogCateProds = dog_cate_prods,
            //};
            return View();
        }


        public async Task<IActionResult> _MenuPartial()
        {
            return PartialView();
        }

        public async Task<IActionResult> _SlidePartial()
        {
            return PartialView();
        }

        public async Task<IActionResult> _ProductPartial()
        {
            return PartialView();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

	}
}

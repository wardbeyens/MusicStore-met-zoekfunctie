using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Components
{
    [ViewComponent(Name = "CartSummary")]
    public class CartSummaryComponent : ViewComponent
    {
        private readonly StoreContext _context;

        public CartSummaryComponent(StoreContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cart = new ShoppingCart(HttpContext, _context);

            if (cart.GetCount() > 0)
            {
                ViewData["CartCount"] = cart.GetCount();
            }
            else
            {
                ViewData["CartCount"] = 0;
            }

            return View();
        }
    }
}
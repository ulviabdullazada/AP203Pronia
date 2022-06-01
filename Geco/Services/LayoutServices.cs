using Geco.DAL;
using Geco.ViewModels;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geco.Services
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _accessor;
        public LayoutServices(AppDbContext context,IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }
        public Dictionary<string,string> GetSettings()
        {
            return _context.Settings.ToDictionary(s => s.Key, s => s.Value);
        }
        public int GetBasketItemCount()
        {
            string basket = _accessor.HttpContext.Request.Cookies["Basket"];
            if (basket == null)
            {
                return 0;
            }
            return JsonConvert.DeserializeObject<List<BasketVM>>(basket).Sum(bvm=>bvm.Count);
        }
    }
}

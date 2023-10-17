using Microsoft.AspNetCore.Mvc;
using Organic.Models;

namespace Startup.Components
{
    [ViewComponent(Name = "MenuView")]
    public class MenuViewComponent : ViewComponent
    {
        private DataContext _dataContext;
        public MenuViewComponent(DataContext context)
        {
            _dataContext = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listOfMenu = (from m in _dataContext.Menus
                              where (m.IsActive == true) && (m.Position == 1)
                              select m).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listOfMenu));
        }
    }
}

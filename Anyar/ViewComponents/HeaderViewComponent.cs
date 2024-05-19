using Microsoft.AspNetCore.Mvc;

namespace Anyar.ViewCompanents
{
    public class HeaderViewComponent:ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}

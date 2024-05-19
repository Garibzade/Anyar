using Microsoft.AspNetCore.Mvc;

namespace Anyar.ViewCompanents
{
    public class HeaderViewCompanent:ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}

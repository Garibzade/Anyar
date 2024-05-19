using Microsoft.AspNetCore.Mvc;

namespace Anyar.ViewCompanents
{
    public class FooterViewComponent:ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}

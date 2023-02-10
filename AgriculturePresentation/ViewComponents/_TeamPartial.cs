using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _TeamPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }  
    }
}

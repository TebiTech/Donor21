using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Donor21.Web.ViewComponents.Account
{
    public class ParentLoginViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("ParentLoginComponent");
        }
    }
}

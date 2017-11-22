using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Donor21.Web.ViewComponents.Account
{
    public class ClinicLoginViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("ClinicLoginComponent");
        }
    }
}

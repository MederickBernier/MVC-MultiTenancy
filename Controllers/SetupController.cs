using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_MultiTenancy.Models;

namespace MVC_MultiTenancy.Controllers {
    public class SetupController : Controller {

        public IActionResult Index() {
            //will do the verifications if the components in the appsettings.json exists or not and will either redirect or show the form based on the result, so there's no going and fucking things up if it's already done.
            return View();
        }
    }
}

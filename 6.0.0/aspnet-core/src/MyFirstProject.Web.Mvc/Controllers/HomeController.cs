using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyFirstProject.Controllers;

namespace MyFirstProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyFirstProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

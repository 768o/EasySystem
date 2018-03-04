using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasySystem.IBLL;
using EasySystem.Model;
using EasySystem.BLLContainer;

namespace EasySystem.UI.Controllers
{
    public class HomeController : Controller
    {
        private IUserService StaffService = Container.Resolve<IUserService>();
        // GET: Home
        public ActionResult Index()
        {
            List<User> list = StaffService.GetModels(p => true).ToList();
            return View(list);
        }
        public ActionResult Add(User staff)
        {
            if (StaffService.Add(staff))
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }
        public ActionResult Update(User staff)
        {
            if (StaffService.Update(staff))
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }
        public ActionResult Delete(int id)
        {
            var staff = StaffService.GetModels(p => p.id == id).FirstOrDefault();
            if (StaffService.Delete(staff))
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }
    }
}
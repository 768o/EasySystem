using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasySystem.IBLL;
using EasySystem.Model;
<<<<<<< HEAD
=======
using EasySystem.BLLContainer;
>>>>>>> 使用文本模板根据数据库表自动生产对应类

namespace Company.UI.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< HEAD
        private IStaffService StaffService = EasySystem.BLLContainer.Container.Resolve<IStaffService>();
        // GET: Home
        public ActionResult Index()
        {
            List<Staff>list = StaffService.GetModels(p => true).ToList();
            return View(list);
        }
        public ActionResult Add(Staff staff)
        {
            if (StaffService.Add(staff))
=======
        private IUserService UserService = Container.Resolve<IUserService>();
        // GET: Home
        public ActionResult Index()
        {
            List<User> list = UserService.GetModels(p => true).ToList();
            return View(list);
        }
        public ActionResult Add(User user)
        {
            if (UserService.Add(user))
>>>>>>> 使用文本模板根据数据库表自动生产对应类
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }
<<<<<<< HEAD
        public ActionResult Update(Staff staff)
        {
            if (StaffService.Update(staff))
=======
        public ActionResult Update(User user)
        {
            if (UserService.Update(user))
>>>>>>> 使用文本模板根据数据库表自动生产对应类
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }
        public ActionResult Delete(int Id)
        {
<<<<<<< HEAD
            var staff = StaffService.GetModels(p => p.Id == Id).FirstOrDefault();
            if (StaffService.Delete(staff))
=======
            var user = UserService.GetModels(p => p.id == Id).FirstOrDefault();
            if (UserService.Delete(user))
>>>>>>> 使用文本模板根据数据库表自动生产对应类
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
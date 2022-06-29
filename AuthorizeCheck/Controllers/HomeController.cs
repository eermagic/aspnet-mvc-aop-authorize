using AuthorizeCheck.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthorizeCheck.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        

        /// <summary>
        /// 擁有會員權限才可訪問
        /// </summary>
        /// <returns></returns>
        [AuthorizeFilter(UserRole.Member)]
        public ActionResult MemberPage()
        {
            return View();
        }

        /// <summary>
        /// 擁有管理員權限才可訪問
        /// </summary>
        /// <returns></returns>
        [AuthorizeFilter(UserRole.Admin)]
        public ActionResult AdminPage()
        {
            return View();
        }

        /// <summary>
        /// 測試登入
        /// </summary>
        /// <returns></returns>
        public ActionResult LoginTest()
        {
            // 省略資料庫查詢動作...

            // 測試會員登入身份
            Session["UserRole"] = "Member";
            return View();
        }
    }
}
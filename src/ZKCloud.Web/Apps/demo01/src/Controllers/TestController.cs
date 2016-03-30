using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ZKCloud.Container;
using ZKCloud.Domain.Repositories;
using ZKCloud.Web.Mvc;
using ZKCloud.Web.Apps.Demo01.Domain.Models;
using ZKCloud.Web.Apps.Demo01.Domain.Repositories;
using Microsoft.AspNet.Mvc.ViewEngines;
using System.IO;
using Microsoft.AspNet.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ZKCloud.Web.Apps.Demo01.Controllers {
	[App("demo01")]
	public class TestController : BaseController {
		// GET: /<controller>/
		public IActionResult Index() {
			string result = "demo01::test::index called.\n";
			//var list = Resolve<TestDataRepository>().ReadMany(e => e.Id < 1000);
			//result += string.Join("", list.Select(e => $"id:{e.Id}, name:{e.Name}\n").ToArray());
			return View((object)result);
		}
        
        /// <summary>
        /// 动态视图返回
        /// </summary>
        /// <returns></returns>
        public IActionResult dynamic()
        {
            string checkType = HttpContext.Items.SingleOrDefault(c => c.Key.Equals("__check__")).Value.ToString();
            if (checkType.Equals("admin"))
            {
                //判断当前是否登陆且是管理员，否则提示没有权限,重新登陆
                return Redirect("/test/noadmin");
                //return Redirect("/admin/login");
            }
            if (checkType.Equals("user"))
            {
                //判断当前是否登陆且是用户角色，否则提示没有权限,重新登陆
                return Redirect("/test/nouser");
                //return Redirect("/user/login");
            }

            string viewName = HttpContext.Items.SingleOrDefault(c => c.Key.Equals("__dynamicviewname__")).Value.ToString();
            return View(viewName);
        }

        [HttpGet("test/noadmin")]
        public IActionResult noadmin()
        {
            ViewBag.message = "该页面需要管理员权限,请用管理员身份登录";
            return View("~/apps/demo01/template/nopermission");
        }
        [HttpGet("test/nouser")]
        public IActionResult nouser()
        {
            ViewBag.message = "该页面需要会员权限,请用先登录";
            return View("~/apps/demo01/template/nopermission");
        }

        public IActionResult Add() {
			Resolve<TestDataRepository>().AddSingle(new TestData()
			{
				Name = "aaaaaaaaaaaa"
			});
			return Content("demo01::test::testadd called.");
		}

		public IActionResult TestView() {
			return View();
		}

		public IActionResult Login() {
			return View();
		}
	}
}

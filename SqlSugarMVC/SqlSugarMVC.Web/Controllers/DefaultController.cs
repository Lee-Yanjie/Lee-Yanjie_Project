using SqlSugar;
using SqlSugarMVC.Interfaces;
using SqlSugarMVC.Models;
using SqlSugarMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SqlSugarMVC.Web.Controllers
{
    public class DefaultController : Controller
    {
        //public ISystemsUser _systemsUser = new SystemsUser(1);

        public ISystemsUser _systemsUser = AutofacContainer.Resolve<ISystemsUser>();
        public ActionResult Index()
        {
            var sysList = _systemsUser.Query();
            var userList = _systemsUser.GetSysUsers();
            return View();
        }
    }
}
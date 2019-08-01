using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientIssueTicketing.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        // will display all the approved users
        public ActionResult Index()
        {
            return View();
        }

        //will display the users for approval
        public ActionResult ForApproval()
        {
            return View();
        }

        //will display the roles
        public ActionResult RolesList()
        {
            return View();
        }

        //will add roles
        public ActionResult AddRoles()
        {
            return View();
        }

        //will edit roles
        public ActionResult EditRoles()
        {
            return View();
        }
    }
}
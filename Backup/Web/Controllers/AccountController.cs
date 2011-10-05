using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using MvcContrib.Attributes;
using MvcValidation.Web.Models;
using MvcValidation.Web.Models.Login;
using MvcValidation.Web.Utilities;
using MvcValidation.Web.Utilities.State;

namespace MvcValidation.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public RedirectToRouteResult LogIn()
        {
            return RedirectToAction("EnterMobile");
        }

        [HttpGet]
        [LoadViewModel]
        [Process(typeof(LoginProcess))]
        public ViewResult EnterMobile()
        {
            return View();
        }

        [HttpPost]
        [ValidateViewModel]
        [Process(typeof(LoginProcess))]
        public ActionResult EnterMobile(EnterMobileInputModel inputModel, EnterMobileStep step)
        {
            step.Proceed(inputModel);
            return null;
        }

        [HttpGet]
        [LoadViewModel]
        [Process(typeof(LoginProcess))]
        public ViewResult EnterLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateViewModel]
        [Process(typeof(LoginProcess))]
        public ActionResult EnterLogin(EnterLoginInputModel inputModel, EnterLoginStep step)
        {
            step.Proceed(inputModel);
            return null;
        }

        [HttpGet]
        [LoadViewModel]
        [Process(typeof(LoginProcess))]
        public ViewResult EnterGuestLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateViewModel]
        [Process(typeof(LoginProcess))]
        public ActionResult EnterGuestLogin(EnterGuestLoginInputModel inputModel, EnterGuestLoginStep step)
        {
            step.Proceed(inputModel);
            return null;
        }

        [HttpGet]
        [LoadModel]
        public RedirectToRouteResult LogOut(LogOutModel model)
        {
            model.LogOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
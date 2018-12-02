﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Dcm.Models;
using BaseDB;
using System.Web.Security;

namespace Dcm.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login(string ReturnUrl)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login model)
        {
            #region Ortak Set Edilecek Değerler
            ViewBag.Success = true;
            #endregion

            ModelState.Remove("RememberMe");

            if (ModelState.IsValid)
            {
                BaseClasses.BaseLogin objLogin = new BaseClasses.BaseLogin();
                
                if (objLogin.UserValidaton(model.Email_Login, model.Password_Login))
                {
                    SessionContext newSession = SessionContext.StartSession();
                    newSession.ActiveUser.UserUid = objLogin.GetUserUid();
                    newSession.ActiveUser.UserNameAndSurname = objLogin.GetUserNameAndSurName();
                    newSession.ActiveUser.UserEmail = objLogin.GetEmail();
                    newSession.ActiveUser.Name = objLogin.GetName();
                    newSession.ActiveUser.Surname = objLogin.GetSurname();
                    newSession.ActiveUser.PublicUserName = objLogin.GetPublicUsername();
                    newSession.ActiveUser.TimeZoneInfoUser = objLogin.GetTimeZoneInfoUser();

                    BaseClasses.SessionKeeper.AddCurrentSession();
                    BaseClasses.SessionKeeper.AddLoggedInUserToDataBase("login");
                    FormsAuthentication.SetAuthCookie(newSession.ActiveUser.UserUid.ToString(), false);


                    if (model.RememberMe)
                    {
                        BaseClasses.BaseFunctions.getInstance().SetLoginCookie(newSession, System.Web.HttpContext.Current.Response);
                    }

                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ViewBag.Success = false;
                    ModelState.AddModelError("Error", Resources.GlobalResource.login_failed);
                }
            }
            else
            {
                
            }

            return View(model);
        }

        [AllowAnonymous]
        public ActionResult Logout()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();

            var cookie = Request.Cookies["DCMGRUP23"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.UtcNow.AddYears(-1);
                Response.Cookies.Add(cookie);
            }

            BaseClasses.SessionKeeper.AddLoggedInUserToDataBase("logout");

            return RedirectToAction("Index", "Home");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;
using VTL_Web.BAL.Login;
using VTL_Web.Global;
using VTL_Web.Infrastructure.Authentication;
using CaptchaMvc.HtmlHelpers;
using Swashbuckle.Swagger;
using System.Configuration;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;
using RestSharp;
using System.IO;
using System.Net;
using static System.Net.WebRequestMethods;
using VTL_Web.BAL.Masters;

namespace VTL_Web.Controllers
{
    public class LoginController : CommonController
    {
        // GET: Login

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetLogin(string username, string password)
        {
            LoginDetails _details = new LoginDetails();
            string _response = string.Empty;
            Enums.LoginMessage message = _details.GetLogin(username, password);
            _response = LoginResponse(message);
            if (message == Enums.LoginMessage.Authenticated)
            {
                setUserClaim();
                //_details.InsertLoginDetail();
                return RedirectToAction("Dashboard", "Admin");
            }
            return RedirectToAction("Index");
        }

        private void setUserClaim()
        {
            CustomPrincipalSerializeModel serializeModel = new CustomPrincipalSerializeModel();
            serializeModel.Id = UserData.UserId;
            serializeModel.FirstName = string.IsNullOrEmpty(UserData.Name) ? string.Empty : UserData.Name;
            serializeModel.Mobile = string.IsNullOrEmpty(UserData.MobileNumber) ? string.Empty : UserData.MobileNumber;
            serializeModel.LastName = string.IsNullOrEmpty(UserData.Username) ? string.Empty : UserData.Username;
            serializeModel.Email = string.IsNullOrEmpty(UserData.Email) ? string.Empty : UserData.Email;
            serializeModel.RoleId = UserData.RoleId != null ? UserData.RoleId : 0;

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string userData = serializer.Serialize(serializeModel);

            FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
                     1,
                     UserData.Email,
                     DateTime.Now,
                     DateTime.Now.AddMinutes(15),
                     false,
                     userData);

            string encTicket = FormsAuthentication.Encrypt(authTicket);
            HttpCookie faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
            Response.Cookies.Add(faCookie);


        }
    }
}
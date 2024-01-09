﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLayer;
using VTL_Web.Global;
using System.Data.Entity;
using System.Web.UI.WebControls;
using log4net.Appender;

namespace VTL_Web.BAL.Login
{
    public class LoginDetails
    {
        vtlDbEntities _db = null;

        /// <summary>
        /// Get Authenticate User credentials
        /// </summary>
        /// <param name="UserName">Username</param>
        /// <param name="Password">Password</param>
        /// <returns>Enums</returns>
        public Enums.LoginMessage GetLogin(string UserName, string Password)
        {
            string _passwordHash = Utility.GetHashString(Password);
            _db = new vtlDbEntities();

            var _userLogin = _db.AdminUsers.Where(x => x.UserName.Equals(UserName) && x.Password.Equals(Password) && x.IsActive == true).FirstOrDefault();

            if (_userLogin != null)
            {
                if (_userLogin != null)
                {
                    if (_userLogin.IsActive == false)
                        return Enums.LoginMessage.UserBlocked;
                }
                UserData.UserId = _userLogin.Id;
                UserData.Username = _userLogin.UserName;
                UserData.Name = _userLogin.Name;
                UserData.MobileNumber = Convert.ToString(_userLogin.MobileNumber);
                UserData.Email = _userLogin.EmailID;
                UserData.RoleId = _userLogin.RoleId;
                return Enums.LoginMessage.Authenticated;
            }
            else
                return Enums.LoginMessage.InvalidCreadential;
        }

        public Enums.LoginMessage ValidateOTP(string UserName, string OTP)
        {
            _db = new vtlDbEntities();
            var _userLogin = _db.AdminUsers.Where(x => x.UserName.Equals(UserName) && x.otp_number == OTP).FirstOrDefault();

            if (_userLogin != null)
            {
                return Enums.LoginMessage.Authenticated;
            }
            else
                return Enums.LoginMessage.InvalidCreadential;
        }
        public Enums.LoginMessage ValidatePACLoginOTP(string UserName, string OTP)
        {
            _db = new vtlDbEntities();
            var _userLogin = _db.PACUsers.Where(x => x.UserName.Equals(UserName) && x.otp_number == OTP).FirstOrDefault();

            if (_userLogin != null)
            {
                return Enums.LoginMessage.Authenticated;
            }
            else
                return Enums.LoginMessage.InvalidCreadential;
        }
        public Enums.LoginMessage PACLogin(string UserName, string Password)
        {
            _db = new vtlDbEntities();

            var _userLogin = _db.PACUsers.Where(x => x.UserName.Equals(UserName) && x.Password.Equals(Password) && x.IsActive == true).FirstOrDefault();

            if (_userLogin != null)
            {
                if (_userLogin != null)
                {
                    if (_userLogin.IsActive == false)
                        return Enums.LoginMessage.UserBlocked;
                }
                UserData.UserId = _userLogin.Id;
                UserData.Username = _userLogin.UserName;
                UserData.Name = _userLogin.Name;
                UserData.MobileNumber = Convert.ToString(_userLogin.MobileNumber);
                UserData.Email = _userLogin.EmailID;
                return Enums.LoginMessage.Authenticated;
            }
            else
                return Enums.LoginMessage.InvalidCreadential;
        }

        public bool InsertLoginDetail()
        {
            _db = new vtlDbEntities();
            var login = new LoginDetail()
            {
                IsLogin = true,
                LoginAt = DateTime.UtcNow,
                UserId = UserData.UserId
            };
            _db.Entry(login).State = EntityState.Added;
            _db.SaveChanges();
            return true;
        }
        public bool UpdateLoginDetail()
        {
            _db = new vtlDbEntities();
            var _userLogin = _db.LoginDetails.Where(x => x.UserId == UserData.UserId && x.IsLogin == true).ToList();
            foreach (var login in _userLogin)
            {
                login.IsLogin = false;
                login.LogoutAt = DateTime.UtcNow;
            }
            _db.SaveChanges();
            return true;
        }
        public bool UpdateLoginDetailWithOTP(string username, string otpNumber)
        {
            _db = new vtlDbEntities();
            var _userLogin = _db.AdminUsers.Where(x => x.UserName == username).FirstOrDefault();
            _userLogin.otp_number = otpNumber;
            _db.SaveChanges();
            return true;
        }
        public bool UpdatePACLoginDetailWithOTP(string username, string otpNumber)
        {
            _db = new vtlDbEntities();
            var _userLogin = _db.PACUsers.Where(x => x.UserName == username).FirstOrDefault();
            _userLogin.otp_number = otpNumber;
            _db.SaveChanges();
            return true;
        }
        public bool? ValidateLoginDetail()
        {
            _db = new vtlDbEntities();
            var _userLogin = _db.LoginDetails.Where(x => x.UserId == UserData.UserId).OrderByDescending(x => x.LoginAt).FirstOrDefault();
            return _userLogin?.IsLogin;
        }
    }
}
﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace VTL_Web.APIController
{
    public class LoginAPIController : ApiController
    {
        /// <summary>
        /// Get Patient List
        /// </summary>
        /// <returns>List of Patientinfo</returns>
        public List<AdminUser> GetPatientInfo(int id)
        {
            List<AdminUser> list = new List<AdminUser>() { new AdminUser() { Id = 1 } };
            return list;
        }
    }
}

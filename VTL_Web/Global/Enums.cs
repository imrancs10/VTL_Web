﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VTL_Web.Global
{
    public static class Enums
    {
        public enum OPDTypeEnum
        {
            IPD = 1,
            OPD = 2,
            DischargeSummary = 3,
            MyVisit = 4
        }
        public enum MasterLookupEnum
        {
            HelpLineNo,
            OPDNo,
            AdministrativeBlockPhNo,
            FaxNo,
            Website,
            EMail,
            MailingAddress
        }
        public enum TransactionType
        {
            Registration = 0,
            Renewal = 1,
            PayBill = 2
        }
        public enum LoginMessage
        {
            Authenticated = 1,
            InvalidCreadential = 2,
            LoginFailed,
            UserDeleted,
            UserInactive,
            UserBlocked,
            NoResponse
        }

        public enum CrudStatus
        {
            Saved = 1,
            NotSaved = 2,
            Updated,
            NotUpdated,
            Deleted,
            NotDeleted,
            DataNotFound,
            DataAlreadyExist,
            SessionExpired,
            InvalidPostedData,
            InvalidPastDate,
            InternalError,
            RegistrationExpired
        }

        public enum ReportType
        {
            Bill,
            Lab
        }

        public enum JsonResult
        {
            Data_NotFound = 100,
            Invalid_DataId = 101,
            Data_Expire = 102,
            Success = 103,
            Unsuccessful
        }
    }
}
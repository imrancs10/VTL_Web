﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VTL_Web.Infrastructure
{
    public class Message
    {
        /// <summary>
        /// Contain Mobile number or Email address
        /// </summary>
        public string MessageTo { get; set; }
        public string MessageNameTo { get; set; }
        public string OTP { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public MessageType MessageType { get; set; }
    }

    public enum MessageType
    {
        Appointment,
        OTP
    }
}
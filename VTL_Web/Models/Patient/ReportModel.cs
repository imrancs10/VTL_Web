﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VTL_Web.Models.Patient
{
    public class ReportModel
    {
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public DateTime Date { get; set; }
        public string ReportName { get; set; }
    }

    public class PatientLedgerModel
    {
        public string Date { get; set; }
        public string IPNo { get; set; }
        public string Type { get; set; }
        public string VNo { get; set; }
        public string Description { get; set; }
        public string Payment { get; set; }
        public string Receipt { get; set; }
        public string Balance { get; set; }
        public string SaleType { get; set; }
        public string schemeid { get; set; }
    }
}
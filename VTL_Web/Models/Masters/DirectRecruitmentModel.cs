﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VTL_Web.Models.Masters
{
    public class DirectRecruitmentModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public Nullable<int> Parent_Id { get; set; }
        public string ParentName { get; set; }
        public string FileName { get; set; }
        public string FIleURL { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<DirectRecruitmentModel> Children { get; set; }
    }
}
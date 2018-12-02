﻿using Dcm.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dcm.Models
{
    public class Project
    {
        [Required]
        public string RecordId { get; set; }
        public string MenuId { get; set; }

        [Required(ErrorMessage = "Project Name is required")]
        public string project_name { get; set; }

        public string project_type_id { get; set; }

        public string kurum_id { get; set; }
        public string birey_id { get; set; }

        public string isveren_mobil_phone { get; set; }
       
        public string note { get; set; }
        public string project_description { get; set; }

        public bool is_active { get; set; }

        public string FromDeleteButton { get; set; }

        public List<crm_kurumlar> activeKurumlar { get; set; }

        public List<crm_bireyler> activeBireyler { get; set; }

        public List<crm_bireyler_kurumlar_v> activeBireylerKurumlar { get; set; }

        public string statik { get; set; }
        public string mekanik { get; set; }

        public string elektrik { get; set; }
        public string harita { get; set; }

        public string yapi_denetim { get; set; }

        public string proje_metrekare { get; set; }

        public string birey_kurum_id { get; set; }

        public List<ref_crm_project_types> projectTypes { get; set; }

        public List<gnl_users> activeUsers { get; set; }

         


    }
}
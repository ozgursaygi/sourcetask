﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using Dcm.EntityModels;

namespace Dcm.Models
{
    public class Notification
    {
        public int id {get;set;}
        public Guid notification_id { get; set; }
        public int notification_type { get; set; }
        public int notification_module_type { get; set; }
        public bool notification_shown { get; set; }

        public DateTime notification_shown_date { get; set; }
        public Guid related_record_id { get; set; }
        public Guid notification_user_id { get; set; }
        public string notification_title { get; set; }
        public string notification_body { get; set; }

        public List<gnl_notifications> activeNotificationList { get; set; }
    }

}
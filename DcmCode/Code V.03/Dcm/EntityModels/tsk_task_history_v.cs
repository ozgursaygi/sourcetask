//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dcm.EntityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class tsk_task_history_v
    {
        public int history_id { get; set; }
        public System.Guid task_id { get; set; }
        public string task_name { get; set; }
        public string task_status_name { get; set; }
        public string assigned_user_name { get; set; }
        public string updated_user { get; set; }
        public string task_priority_name { get; set; }
        public Nullable<System.DateTime> history_at { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using Dcm.EntityModels;

namespace Dcm.Models
{
    public class User
    {
        [Required]
        public string RecordId  {get;set;}
        public string MenuId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string name {get;set;}

        [Required(ErrorMessage = "Surname is required")]
        public string surname {get;set;}

        [Required(ErrorMessage = "Email is required.")]
        public string email {get;set;}
        public string password {get;set;}

        public string oldPassword { get; set; }
        public string newPassword { get; set; }

        public string newPasswordRepeat { get; set; }

        [Required(ErrorMessage = "Mobile Phone is required.")]
        public string mobile_phone {get;set;}
        public string home_phone {get;set;}
        public string identity_number {get;set;}

        [Required(ErrorMessage = "Name is required.")]
        public DateTime birth_date {get;set;}
        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string address {get;set;}
        public string note {get;set;}

        public bool is_active {get;set;}

        public string FromDeleteButton { get; set; }

        public List<gnl_user_groups> activeGroups { get; set; }

        public string SelectedGroupId { get; set; }

        public string ManagerId { get; set; }

        public string ManagerName { get; set; }
        
    }

    public class UserListModel
    {
        public UserListCategoryModel data = new UserListCategoryModel();
        public string value { get; set; }
    }

    public class UserListCategoryModel
    {
        public string category { get; set; }
        public string id { get; set; }
    }

}
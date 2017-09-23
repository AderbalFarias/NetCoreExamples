﻿using System.ComponentModel.DataAnnotations;

namespace AboutNetCore.Version1_0.DefaultTemplate.ViewModels.Manage
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
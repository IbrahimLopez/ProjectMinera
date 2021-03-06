﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectMinera.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        public string userID { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //[Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [Required]
        [DisplayName("Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [DisplayName("Rol")]
        public string RolName { get; set; }

        public string hash { get; set; }
        public string stamp { get; set; }        

        public RegisterViewModel() { }
        public RegisterViewModel(ApplicationUser admin)
        {
            this.Email = admin.Email;
            this.Nombre = admin.Nombre;
            this.ApellidoPaterno = admin.ApellidoPaterno;
            this.ApellidoMaterno = admin.ApellidoMaterno;
            this.userID = admin.Id;
            this.hash = admin.PasswordHash;
            this.stamp = admin.SecurityStamp;
        }
        //public string userID { get; set; }

        //[Required]
        //[EmailAddress]
        //[Display(Name = "Email")]
        //public string Email { get; set; }

        //[Required]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        //[DataType(DataType.Password)]
        //[Display(Name = "Password")]
        //public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }

        //[Required]
        //[DisplayName("Nombre")]
        //public string Nombre { get; set; }

        //[Required]
        //[DisplayName("Apellido Paterno")]
        //public string ApellidoPaterno { get; set; }

        //[Required]
        //[DisplayName("Apellido Materno")]
        //public string ApellidoMaterno { get; set; }

        //[DisplayName("Rol")]
        //public string RolName { get; set; }

        //public string hash { get; set; }
        //public string stamp { get; set; }

        //public RegisterViewModel() { }
        //public RegisterViewModel(ApplicationUser admin)
        //{
        //    this.Email = admin.Email;
        //    this.Nombre = admin.Nombre;
        //    this.ApellidoPaterno = admin.ApellidoPaterno;
        //    this.ApellidoMaterno = admin.ApellidoMaterno;
        //    this.userID = admin.Id;
        //    this.hash = admin.PasswordHash;
        //    this.stamp = admin.SecurityStamp;
        //}

    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

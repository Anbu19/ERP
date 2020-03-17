using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee_App.ViewModels
{
    public class EmployeeViewModel
    {
        public int UserRowId { get; set; }
        [Display(Name = "Login Id")]
        [Required(ErrorMessage = "User Id is Required")]
        public string LoginID { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Display(Name = "Email Id")]
        [Required(ErrorMessage = "Email Id is Required")]
        public string EmailID { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Role Id is Required")]
        [Display(Name = "Role")]
        public int RoleID { get; set; }
        public int? Cby { get; set; }
        public System.DateTime? Cdt { get; set; }
        public int? Mby { get; set; }
        public System.DateTime? Mdt { get; set; }
        public virtual RoleViewModel Role { get; set; }
    }
}
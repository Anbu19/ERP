using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee_App.ViewModels
{
    public class RoleViewModel
    {
        public int RoleID { get; set; }
        [Required(ErrorMessage = "Role Name is Required")]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
        public int? Cby { get; set; }
        public System.DateTime? Cdt { get; set; }
        public int? Mby { get; set; }
        public System.DateTime? Mdt { get; set; }      
        public virtual ICollection<EmployeeViewModel> Employees { get; set; }
    }
}
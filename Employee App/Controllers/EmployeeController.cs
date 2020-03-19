using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.DirectoryServices.AccountManagement;
using System.Security.Principal;
using System.Management;

namespace Employee_App.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Create()
        {
            string userName = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
            string machineName = WindowsIdentity.GetCurrent().Name.Split('\\')[0];
            //PrincipalContext c = new PrincipalContext(ContextType.Machine, machineName);
            ////Specific User
            //UserPrincipal uc = UserPrincipal.FindByIdentity(c, "Anbalagank");
            //DateTime? LoggedInTime = uc.LastLogon;

            ////Current LoggedIn User
            //uc = UserPrincipal.FindByIdentity(c, userName);
            //DateTime? CurrentUserLoggedInTime = uc.LastLogon;

            ManagementScope ms = new ManagementScope("\\root\\cimv2");

            ObjectQuery oq = new ObjectQuery("Select * from Win32_Session");

            ManagementObjectSearcher query = new ManagementObjectSearcher(ms, oq);

            ManagementObjectCollection queryCollection = query.Get();

            foreach (ManagementObject mo in queryCollection)

            {

                if (mo["LogonType"].ToString().Equals("2"))
                //  2 - for logged on User

                {
                    Response.Write("Started Time: " + mo["StartTime"].ToString());

                }

            }
            return View();
        }

    }
}
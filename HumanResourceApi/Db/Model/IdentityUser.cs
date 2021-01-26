using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceApi.Db.Model
{
    // Add profile data for application users by adding properties to the HumanResourceApplicationMainMainUser class
    public class IdentityUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
      
    }
    public enum Contract
    {
        DualStudies,
        FullTime,
        PartTime,

    }
    public enum Roles
    {
        Manager,
        Employee
    }
}

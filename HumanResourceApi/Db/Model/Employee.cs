using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceApi.Db.Model
{
    public class Employee
    {
      [Key]
        public int EmployeeId { get; set; }

        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        [PersonalData]
        public DateTime Date { get; set; }
        [PersonalData]
        public string NickName { get; set; }
        [PersonalData]
        public Roles Roles { get; set; }
        [PersonalData]
        public Contract Contract { get; set; }

       
        public string Email { get; set; }

        public string UserName { get; set; }

    }

   

}


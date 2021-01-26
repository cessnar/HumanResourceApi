using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceApi.Db.Model
{
    public class Salary
    {
        [Key]
        public int SubUserId { get; set; }

        public string Name { get; set; }
        public string GrossSalary { get; set; }
        public string Tax { get; set; }
        public string HealthInsurance { get; set; }
        public string NET_Nis { get; set; }
        public string NET_Usd { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId  { get; set; }
        public Employee Employee { get; set; }


    }
}

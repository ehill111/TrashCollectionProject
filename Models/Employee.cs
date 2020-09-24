using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectionRiches.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "Employee Id", Order = -9)]
        public int EmployeeId { get; set; }
        [Display(Name = "First Name", Order = -9)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name", Order = -9)]
        public string LastName { get; set; }
        [Display(Name = "Zip Code", Order = -9)]
        public int ZipCode { get; set; }
        [Display(Name = "Employee View Day", Order = -9)]
        public string EmployeeViewDay { get; set; }
        [Display(Name = "PickUp Completed")]
        public bool PickUpCompleted { get; set; }
        [Display(Name = "Identity User Id", Order = -9)]
        public string IdentityUserId { get; internal set; }
    }
}

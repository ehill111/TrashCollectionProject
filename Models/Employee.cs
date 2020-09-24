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
        [Display(Name = "Street Address", Order = -9)]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zip Code", Order = -9)]
        public int ZipCode { get; set; }
        [Display(Name = "Identity User Id", Order = -9)]
        public string IdentityUserId { get; internal set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectionRiches.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
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
        public int Balance {get; set;}
        [Display(Name = "PickUp Day", Order = -9)]
        public string PickUpDay { get; set; }
        [Display(Name = "Special PickUp Date", Order = -9)]
        public string SpecialPickUpDate { get; set; }
        [Display(Name = "Suspend Start", Order = -9)]
        public DateTime SuspendStart { get; set; }
        [Display(Name = "Suspend Stop", Order = -9)]
        public DateTime SuspendStop { get; set; }
        [Display(Name = "PickUp Completed")]
        public bool PickUpCompleted { get; set; }
    }
}

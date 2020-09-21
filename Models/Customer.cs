﻿using System;
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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int Balance {get; set;}
        public string PickUpDay { get; set; }
        public DateTime SpecialPickUpDate { get; set; }
        public DateTime SuspendStart { get; set; }
        public DateTime SuspendStop { get; set; }

    }
}

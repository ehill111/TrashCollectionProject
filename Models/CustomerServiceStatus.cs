﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectionRiches.Models
{
    public class CustomerServiceStatus
    {
        [Key]
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public bool SuspendedCustomerRequest { get; set; }
        public bool SuspendedPastDue { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectionRiches.Models
{
    public class CustomerAccount
    {   [Key]
        public string ServiceStartDate { get; set; }
        public string ServiceStopDate { get; set; }
        public string PickUpDay { get; set; }
        public string PickUpStatus { get; set; }
        public string PaymentStatus { get; set; }
    }
}

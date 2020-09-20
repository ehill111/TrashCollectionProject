using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectionRiches.Models
{   
    public class CustomerSpecialPickUp
    {
        [Key]
        public bool SpecialPickUp { get; set; }
        public DateTime SpecialPickUpDate { get; set; }
        public bool SpecialPickUpCancel { get; set; }
    }
}

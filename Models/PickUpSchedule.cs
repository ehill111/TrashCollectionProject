using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectionRiches.Models
{
    public class PickUpSchedule
    {   [Key]
        public DayOfWeek Day { get; set; }
    }
}

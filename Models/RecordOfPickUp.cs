using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectionRiches.Models
{
    public class RecordOfPickUp
    {   [Key]
        public int RecordOfPickUpId { get; set; }
        public DateTime Date { get; set; }
    }
}

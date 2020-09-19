using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectionRiches.Models
{
    public class CustomerPayRecord
    {
        [Key]
        public int AmountDue { get; set; }
        public string AmountDueDate { get; set; }
        public int AmountReceived { get; set; }
        public string AmountReceivedDate { get; set; }
        public int AmountCredit { get; set; }
        public int AmountPastDue { get; set; }

    }
}

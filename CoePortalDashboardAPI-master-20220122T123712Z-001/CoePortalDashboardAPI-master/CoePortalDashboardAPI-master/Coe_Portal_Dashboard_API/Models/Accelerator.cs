using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Coe_Portal_Dashboard_API.Models
{
    public class Accelerator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int accId { get; set; }

        public string accName { get; set; }

        public string accDescr { get; set; }

        public string accUrl { get; set; }

        public string accImg { get; set; }

        public string accDoc { get; set; }

        public string accVideo { get; set; }

       

    }
}

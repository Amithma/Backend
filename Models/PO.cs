using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Models
{
    public class PO
    {
        [Key]
        public String POID { get; set; }
        public String POName { get; set; }


        [ForeignKey("LO")]
        public int ID { get; set; }
        public string LOID { get; set; }
        public LO LO { get; set; }

        public ICollection<AsComponent> AsComponents { get; set; }
        
    }
}

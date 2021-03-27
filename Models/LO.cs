using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AuthDemo.Models
{
    public class LO
    {

        [Key]
        public int ID { get; set; }
        public String LOID { get; set; }
        public string Name { get; set; }
        [ForeignKey("Module")]
        public string ModuleId { get; set; }
        public Module Module { get; set; }

        public ICollection<PO> POs { get; set; }


    }
}

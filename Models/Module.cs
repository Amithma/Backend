using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Models
{
    public class Module
    {
        [Key]
        public String ModuleId { get; set; }
        public String Name { get; set; }

        public String Credits { get; set; }
        public String type { get; set; }
        public String State { get; set; }

        public ICollection<LO> LOs { get; set; }

        public ICollection<AsComponent> AsComponents { get; set; }
    }
}

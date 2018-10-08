using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSMonitor.Models
{
    public class ExperimentContext
    {
        public int ID {get; set;}
        public int ExperimentID { get; set; }

        public virtual ICollection<Snapshot> Snapshots { get; set; }
    }
}
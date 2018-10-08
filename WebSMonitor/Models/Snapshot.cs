using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scalarm;

namespace WebSMonitor.Models
{
    public class Snapshot
    {
        public int ID { get; set; }
        public string ExperimentID { get; set; }
        public DateTime Taken { get; set; }
        public IList<ValuesMap> Content { get; set; }
    }
}
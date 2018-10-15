using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebSMonitor.Models
{
    public class ImmediateResult
    { 
        public int ID { get; set; }
        public string ControlPoints { get; set; }
        //Discretization Points Count
        public int Dpc { get; set; }
        public double ErrorValue { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class ImmediateResultDBContext : DbContext
    {
        public DbSet<ImmediateResult> ImmediateResults { get; set; }
    }
}
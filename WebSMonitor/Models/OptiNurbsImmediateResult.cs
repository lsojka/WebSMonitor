using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSMonitor.Models
{
    public class OptiNurbsImmediateResult
    { 
        public string ControlPoints { get; set; }
        //Discretization Points Count
        public int Dpc { get; set; }
        public double ErrorValue { get; set; }
    }
}
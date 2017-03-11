using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MergeTest.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Destination { get; set; }
        public float TargetAmt { get; set; }
        public int Testprop { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace LearnDotNet.Model
{
    public class Spending
    {
        public int id { get; set; }
        public string reason { get; set; }
        public DateTime date { get; set; }
        public decimal amount { get; set; }
        public DateTime sys_date { get; set; }
    }
}
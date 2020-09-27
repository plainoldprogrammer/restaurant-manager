using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Wages
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public int? Amount { get; set; }
    }
}

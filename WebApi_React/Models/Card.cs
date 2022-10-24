using System;
using System.Collections.Generic;

namespace WebApi_React.Models
{
    public partial class Card
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Descr { get; set; }
    }
}

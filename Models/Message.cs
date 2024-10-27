﻿using System;
using System.Collections.Generic;

namespace Bestshop.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Message1 { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}

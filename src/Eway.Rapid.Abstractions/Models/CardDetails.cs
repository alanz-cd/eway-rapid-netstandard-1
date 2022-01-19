﻿namespace Eway.Rapid.Abstractions.Models
{
    public class CardDetails
    {
        public virtual string Number { get; set; }
        public string Name { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
        public string StartMonth { get; set; }
        public string StartYear { get; set; }
        public string IssueNumber { get; set; }
        public string CVN { get; set; }
    }
}

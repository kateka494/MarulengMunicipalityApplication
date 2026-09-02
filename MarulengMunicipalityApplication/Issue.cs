using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarulengMunicipalityApplication
{
    public class Issue
    {
        // Properties
        public int Id { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> Attachments { get; set; }
        public DateTime Timestamp { get; set; }
        public string Status { get; set; }    
        public string Priority { get; set; }    
        public Issue(string location, string category, string description)
        {
            Location = location;
            Category = category;
            Description = description;
            Attachments = new List<string>();
            Timestamp = DateTime.Now;
            Status = "Pending";
            Priority = "Medium";
        }

        // Override ToString for display
        public override string ToString()
        {
            return $"#{Id}: {Category} - {Location} ({Status})";
        }
    }
}
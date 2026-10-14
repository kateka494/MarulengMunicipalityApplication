
using System;

namespace MarulengMunicipalityApplication
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public int Priority { get; set; }

        public Event(string name, string category,
                     string description, string location,
                     DateTime date, string type)
        {
            Name = name;
            Category = category;
            Description = description;
            Location = location;
            Date = date;
            Type = type;
            Priority = 1;
        }

        public override string ToString()
        {
            return $"{Name} - {Date:dd MMM yyyy}";
        }
    }
}

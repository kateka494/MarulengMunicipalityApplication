
using System.Collections.Generic;
using System.Linq;

namespace MarulengMunicipalityApplication
{
    public class EventUrgency
    {
        private List<Event> events = new List<Event>();

        // Add an event to the priority list
        public void AddEvent(Event item)
        {
            events.Add(item);
        }

        // Return the highest-priority event first
        public Event GetNextEvent()
        {
            if (events.Count == 0)
                return null;

            Event nextEvent = events
                .OrderByDescending(e => e.Priority)
                .ThenBy(e => e.Date)
                .First();

            events.Remove(nextEvent);

            return nextEvent;
        }

        // Check whether there are events left
        public bool IsEmpty()
        {
            return events.Count == 0;
        }

        // Clear the priority list
        public void Clear()
        {
            events.Clear();
        }
    }
}

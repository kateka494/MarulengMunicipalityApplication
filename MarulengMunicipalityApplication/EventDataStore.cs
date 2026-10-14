
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarulengMunicipalityApplication
{
    public static class EventDataStore
    {
        // Store all events
        public static List<Event> Events = new List<Event>();

        // Store events waiting to be processed
        public static Queue<Event> EventQueue = new Queue<Event>();

        // Store recent searches (last search comes out first)
        public static Stack<string> SearchHistory = new Stack<string>();

        // Find events using their ID
        public static Dictionary<int, Event> EventDictionary =
            new Dictionary<int, Event>();

        // Organise events by date
        public static SortedDictionary<DateTime, List<Event>> EventsByDate =
            new SortedDictionary<DateTime, List<Event>>();

        // Store unique categories
        public static HashSet<string> Categories =
            new HashSet<string>();

        // Assign unique IDs
        private static int nextId = 1;

        // Add an event
        public static void AddEvent(Event newEvent)
        {
            newEvent.Id = nextId++;

            Events.Add(newEvent);

            EventQueue.Enqueue(newEvent);

            EventDictionary[newEvent.Id] = newEvent;

            // Add event to sorted dictionary
            DateTime eventDate = newEvent.Date.Date;

            if (!EventsByDate.ContainsKey(eventDate))
            {
                EventsByDate[eventDate] = new List<Event>();
            }

            EventsByDate[eventDate].Add(newEvent);

            // Add category without duplicates
            Categories.Add(newEvent.Category);
        }

        // Get event using ID
        public static Event GetEventById(int id)
        {
            if (EventDictionary.ContainsKey(id))
            {
                return EventDictionary[id];
            }

            return null;
        }

        // Get all upcoming events
        public static List<Event> GetUpcomingEvents()
        {
            return Events
                .Where(e => e.Date.Date >= DateTime.Today)
                .OrderBy(e => e.Date)
                .ToList();
        }

        // Search events by category
        public static List<Event> SearchByCategory(string category)
        {
            return Events
                .Where(e => e.Category.Equals(
                    category, StringComparison.OrdinalIgnoreCase))
                .OrderBy(e => e.Date)
                .ToList();
        }

        // Search events by date
        public static List<Event> SearchByDate(DateTime date)
        {
            return Events
                .Where(e => e.Date.Date == date.Date)
                .OrderBy(e => e.Date)
                .ToList();
        }

        // Save a search
        public static void AddSearch(string search)
        {
            if (!string.IsNullOrWhiteSpace(search))
            {
                SearchHistory.Push(search.Trim());
            }
        }

        // Get recent search
        public static string GetLastSearch()
        {
            if (SearchHistory.Count > 0)
            {
                return SearchHistory.Peek();
            }

            return "No searches yet";
        }

        // Get the next event in the queue
        public static Event GetNextEvent()
        {
            if (EventQueue.Count > 0)
            {
                return EventQueue.Dequeue();
            }

            return null;
        }
    }
}

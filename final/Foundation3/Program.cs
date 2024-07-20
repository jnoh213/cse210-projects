using System;

class Program
{
    static void Main(string[] args)
    {
        // Create event objects
        Event lecture = new Lecture("AI Seminar", "Introduction to AI", "2024-08-01", "10:00 AM", "123 AI St", "Dr. Smith", 100);
        Event reception = new Reception("Networking Event", "Meet industry experts", "2024-08-05", "6:00 PM", "456 Biz Blvd", "rsvp@network.com");
        Event outdoorGathering = new OutdoorGathering("Summer Fest", "Fun in the sun", "2024-08-10", "2:00 PM", "789 Park Ln", "Sunny");

        // Store events in a list
        var events = new List<Event> { lecture, reception, outdoorGathering };

        // Display information for each event
        foreach (var eventItem in events)
        {
            Console.WriteLine(eventItem.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(eventItem.GetShortDescription());
            Console.WriteLine();
        }
    }
}

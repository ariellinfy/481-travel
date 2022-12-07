using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace travel.Model
{
    public class StateModel
    {
        public bool isGuest { get; set; } = true;

        public bool ShowNav { get; set; } = false; 

        public bool OnSearch { get; set; } = false;

        public bool JustLogout { get; set; } = false;

        public Amenity[]? AllAmenities { get; set; }

        public Event[]? AllEvents { get; set; }

        public List<Amenity> PopularAmenities { get; set; } = new List<Amenity>();

        public List<Event> PopularEvents { get; set; } = new List<Event> { };

        public List<Amenity> SuggestedAmenities { get; set; } = new List<Amenity>();

        public List<Event> SuggestedEvents { get; set; } = new List<Event> { };

        public Trip[]? DummyTrips { get; set; }

        public Plan[]? DummyPlans { get; set; }

        public Plan[]? GenTrip1 { get; set; }

        public Plan[]? GenTrip2 { get; set; }

        public Plan[]? GenTrip3 { get; set; }

        public Plan[]? GenTrip4 { get; set; }

    }
}

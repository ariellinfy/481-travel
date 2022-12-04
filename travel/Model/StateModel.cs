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

        public int OnTab { get; set; }

        public bool JustLogout { get; set; } = false;

        public Amenity[]? AllAmenities { get; set; }

        public Event[]? AllEvents { get; set; }

        public Amenity[]? PopularAmenities { get; set; }

        public Event[]? PopularEvents { get; set; }

        public Amenity[]? SuggestedAmenities { get; set; }

        public Event[]? SuggestedEvents { get; set; }
    }
}

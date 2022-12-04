using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace travel.Model
{
    public class StateModel
    {
        public bool showNav { get; set; }

        public bool onSearch { get; set; }

        public int onTab { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string DisplayName { get; set; }
        //public string Location { get; set; }

        public List<Trip> Trips { get; set; }

        public List<Place> Bookmarks { get; set; }

        public List<Review> Reviews { get; set; }

        public bool Offline { get; set; }

        public List<Place> Notifications { get; set; }

        public List<Amenity> SuggestedAmenity { get; set; } // searched

        public List<Event> SuggestedEvent { get; set; } // searched
    }
}

using System.ComponentModel.DataAnnotations;

namespace travel.Model
{
    public class UserModel
    {
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Password is required")]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<Trip> Trips { get; set; }

        public List<Place> Bookmarks { get; set; }

        public List<Review> Reviews { get; set; }

        public bool Offline { get; set; }

        public List<Place> Notifications { get; set; }

        public List<Amenity> SuggestedAmenity { get; set; } // searched

        public List<Event> SuggestedEvent { get; set; } // searched

        public UserModel()
        {

        }
    }
}

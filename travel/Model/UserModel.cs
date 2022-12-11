namespace travel.Model
{
    public class UserModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string DisplayName { get; set; }
        //public string Location { get; set; }

        public List<Trip> Trips { get; set; } = new List<Trip>();

        public List<Amenity> BookmarksAmenity { get; set; } = new List<Amenity>();

        public List<Event> BookmarksEvent { get; set; } = new List<Event>();

        public List<Review> Reviews { get; set; } = new List<Review>();

        public bool Offline { get; set; } = false;

        public int Notification { get; set; } = 30;

        public List<Amenity> SuggestedAmenity { get; set; } = new List<Amenity>(); // searched

        public List<Event> SuggestedEvent { get; set; } = new List<Event>(); // searched

        public HashSet<Place> Visited { get; set; } = new HashSet<Place>();

        public void ClearUserData()
        {
            Email = "";
            Password = "";
            DisplayName = "";
            Trips.Clear();
            BookmarksAmenity.Clear();
            BookmarksEvent.Clear();
            Reviews.Clear();
            Notification = 30;
            SuggestedAmenity.Clear();
            SuggestedEvent.Clear();
        }
    }
}

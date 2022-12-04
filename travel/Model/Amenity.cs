namespace travel.Model
{
    public class Amenity : Place
    {
        public int Rating { get; set; }

        public List<Review> Reviews { get; set; }

        //public List<string> SimilarPlaces { get; set; }

        public List<string> Similar { get; set; }
    }
}

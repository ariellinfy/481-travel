namespace travel.Model
{
    public class Amenity : Place
    {
        public float Rating { get; set; }

        public List<Review> Reviews { get; set; }


        public Amenity()
        {

        }
    }
}

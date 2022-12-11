namespace travel.Model
{
    public class Review
    {
        public Place place { get; set; }

        public string user { get; set; }

        public string published { get; set; }

        public int rating { get; set; } = 3;

        public string review { get; set; }
    }
}

namespace travel.Model
{
    public class Place
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public List<Category> Categories { get; set; }

        public List<Tag> Tags { get; set; }

        public Place()
        {

        }
    }
}

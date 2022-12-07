namespace travel.Model
{
    public class Event : Place
    {
        public string Date { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public List<int> SimilarEvents { get; set; }
    }
}

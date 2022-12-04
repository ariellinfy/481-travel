namespace travel.Model
{
    public class Plan
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Address { get; set; }

        public string Notes { get; set; }

        public bool toNotify { get; set; }
    }
}

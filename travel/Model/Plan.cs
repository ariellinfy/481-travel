namespace travel.Model
{
    public class Plan
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Date { get; set; }

        public string Start { get; set; }

        public string End { get; set; }

        public string Address { get; set; }

        public string Notes { get; set; }

        public bool Notify { get; set; }
    }
}

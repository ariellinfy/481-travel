using System.ComponentModel.DataAnnotations;

namespace travel.Model
{
    public class Trip
    {
        public string id { get; set; }

        [DataType(DataType.Text)]
        public string Name { get; set; }

        public string StartDay { get; set; }

        public string EndDay { get; set; }

        public string Days { get; set; }

        public List<Plan> Plans { get; set; } = new List<Plan>();
    }
}

using System.ComponentModel.DataAnnotations;

namespace travel.Model
{
    public class RecommendedTripModel : Trip
    {
        public DateTime Start { get; set; }

        public DateTime End { get; set; }
        public List<string> DesiredTypes { get; set; } = new List<string>();
    }
}

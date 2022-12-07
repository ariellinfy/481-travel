using System.ComponentModel.DataAnnotations;

namespace travel.Model
{
    public class RecommendedTripModel : Trip
    {
        public DateTime Start { get; set; } = DateTime.Now;

        public DateTime End { get; set; } = DateTime.Now;
        public List<string> DesiredTypes { get; set; } = new List<string>();
    }
}

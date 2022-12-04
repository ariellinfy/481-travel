using System.ComponentModel.DataAnnotations;

namespace travel.Model
{
    public class Trip
    {
        [DataType(DataType.Text)]
        public string Name { get; set; }

        public List<Plan> Plans { get; set; } = new List<Plan>();
    }
}

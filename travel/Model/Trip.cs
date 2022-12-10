using System.ComponentModel.DataAnnotations;

namespace travel.Model
{
    public class Trip
    {
        public string id { get; set; }

        [DataType(DataType.Text)]
        public string Name { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string Days { get; set; }

        public List<Plan> Plans { get; set; } = new List<Plan>();

        public void DeletePlan()
        {
            Name = "";
            StartDate = "";
            EndDate = "";
            Days = "";
            Plans.Clear();
        }
    }
}

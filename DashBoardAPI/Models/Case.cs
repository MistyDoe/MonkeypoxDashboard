using System.ComponentModel.DataAnnotations.Schema;

namespace DashBoardAPI.Models
{
    [Table("Cases")]
    public class Case
    {
        public string Id { get; set; }
        public DateTime date { get; set; }
        public string location { get; set; }
        public double total_cases { get; set; }
    }
}

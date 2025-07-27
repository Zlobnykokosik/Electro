using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.Models.Add
{
    [Index(nameof(ConsumptionDate), nameof(PointAddID), IsUnique = true)]
    public class ConsumptionAdd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public uint Month { get; set; }
        public required DateOnly ConsumptionDate { get; set; }
        public required float Consumption { get; set; }
        public int? PointAddID { get; set; }
        public PointAdd? PointAddAdd { get; set; }
    }
}

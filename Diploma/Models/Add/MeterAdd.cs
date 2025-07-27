using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.Models.Add
{
    public class MeterAdd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public required int ID { get; set; }
        [StringLength(50)] public required string Number { get; set; }
        public required bool Active{ get; set; } 
        public DateOnly СommissioningDate { get; set; }
        public bool IsClosed { get; set; }
        public DateOnly? CloseDate { get; set; } = null;
        public MountMeterAdd? MountMeter { get; set; }
    }
}

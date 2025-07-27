using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.Models.Add
{
    public class MountMeterAdd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public  int ID { get; set; }
        public required bool Active { get; set; }
        public required DateOnly SetDate { get; set; }
        public int? MeterAddID { get; set; }
        public MeterAdd? MeterAdd { get; set; }
        public bool IsClosed { get; set; }
        public DateOnly? CloseDate { get; set; } = null;
        public int? UnitAddID { get; set; }
        public UnitAdd? UnitAdd { get; set; }
        public List<ReadingAdd>? ReadingAdd { get; set; }

    }

}
    
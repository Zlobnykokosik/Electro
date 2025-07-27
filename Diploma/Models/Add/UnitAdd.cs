using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.Models.Add
{
    public class UnitAdd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public  int ID { get; set; }
        public bool Type { get; set; } = true;

        public int? PointAddId { get; set; }
        public PointAdd? PointAdd { get; set; }
        public MountMeterAdd? MountMeterAdd { get; set; }
        public bool IsClosed { get; set; }
        public DateOnly? CloseDate { get; set; } = null;
    }
}

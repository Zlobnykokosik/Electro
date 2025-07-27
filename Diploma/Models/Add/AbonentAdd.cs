using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.Models.Add
{
    [Index(nameof(AbonentNumber), nameof(ContractAddId), IsUnique = true)]
    public class AbonentAdd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public  int ID { get; set; }
        public required int AbonentNumber { get; set; }
        public required DateOnly ConclusionDate { get; set; }
        [StringLength(100)]
        public required string Name { get; set; }
        [StringLength(150)]
        public required string Address { get; set; }
        public bool ChangeStatus { get; set; } = false;
        public int? ContractAddId { get; set; }
        public ContractAdd? ContractAdd { get; set; }
        public int? ControllersAddId { get; set; }
        public ControllersAdd? ControllersAdd { get; set; }

        public bool IsClosed {  get; set; }
        public DateOnly? CloseDate { get; set; } = null;
        public virtual List<PointAdd> Points { get; set; } = [];
    }
}

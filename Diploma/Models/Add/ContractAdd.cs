using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.Models.Add
{
    [Index(nameof(ContractNumber), IsUnique = true)]
    public class ContractAdd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public required int ID { get; set; } 
        public required int ContractNumber { get; set; }

        [StringLength(150)] public required string FIO { get; set; }
        [StringLength(150)] public required string Address { get; set; }
        public DateOnly ConclusionDate { get; set; }
        public bool IsClosed { get; set; }
        public DateOnly? CloseDate { get; set; } = null;
        public virtual List<AbonentAdd> Abonents { get; set; } = [];
    }
}

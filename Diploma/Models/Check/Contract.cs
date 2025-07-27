using System.ComponentModel.DataAnnotations;

namespace Diploma.Models.Check
{
    public class Contract
    {
        [Key] public required int ID { get; set; } 
        public required int ContractNumber { get; set; }
        public DateOnly? ConclusionDate { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public DateOnly? EndDate { get; set; }

    }
}

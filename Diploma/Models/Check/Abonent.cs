using System.ComponentModel.DataAnnotations;

namespace Diploma.Models.Check
{
    public class Abonent
    {
        [Key] public required int ID { get; set; }
        public required int ContractNumber { get; set; }
        public required int AbonentNumber { get; set; }
        public DateOnly ConclusionDate { get; set; }
        public bool ChangeStatus { get; set; } = false;
        public required virtual List<Point> Points { get; set; } = [];
    }
}

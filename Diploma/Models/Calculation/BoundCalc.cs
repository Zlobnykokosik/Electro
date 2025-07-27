using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Diploma.Models.Calculation
{
    public class BoundCalc
    {
        [Key] public int Id { get; set; }
        public required int Contract { get; set; }
        public required int Abonent { get; set; }
        public required string Month { get; set; }
        public required string PointNumber { get; set; }
        [StringLength(6)] public required string Group { get; set; }
        public required string ControllerName { get; set; }
        [StringLength(16)] public required string MeterNumber { get; set; }
        public required DateTime InitialDate { get; set; }
        public required float? InitialReadings { get; set; }
        public required DateTime FinalDate { get; set; }
        public required float? FinalReadings { get; set; }
        public required int? Koef_TransformerA { get; set; }
        public required int? Koef_TransformerV { get; set; }
        public required float? Difference { get; set; }
        public required float? Result { get; set; }

        //public int? CLCLSS { get; set; }
        //public string? TPCHARGE { get; set; }
        //public required int COUNT { get; set; }
        //public required char type { get; set; }
    }
}

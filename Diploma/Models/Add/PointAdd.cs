using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.Models.Add
{
    [Index(nameof(Number), IsUnique = true)]
    public class PointAdd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public required int Number { get; set; }
        [StringLength(100)] public required string Location { get; set; }
        public required VersionType Version { get; set; }
        public required CalcType Type { get; set; }
        public bool IsClosed { get; set; }
        public DateOnly? CloseDate { get; set; } = null;
        public  virtual List<UnitAdd> Units { get; set; } = [];

        //public int? ContractAddId { get; set; }
        //public ContractAdd? ContractAdd { get; set; }
        public int? AbonentAddId { get; set; }
        public AbonentAdd? AbonentAdd { get; set; }

        [InverseProperty("PointBase")]
        public  virtual List<PointsBoundAdd>? PointsBoundBase { get; set; }
        [InverseProperty("PointMinus")]
        public  virtual List<PointsBoundAdd>? PointsBoundMinus { get; set; }
        public  virtual MountTrasformer? MountTrasformers { get; set; }
        public  virtual List<ConsumptionAdd>? ConsumptionAdd { get; set; }

    }

    public enum CalcType {
        [Display(Name = "Статичный расход")]
        CalcStatic,
        [Display(Name = "Связанные ТУ")]
        CalcBounds,
        [Display(Name = "Простой")]
        CalcComman,
    }

    public enum VersionType
    {
        [Display(Name = "Расчетная")]
        Calc,
        [Display(Name = "Контрольная")]
        Control,
        [Display(Name = "Тех учет")]
        Tech,
    }

}

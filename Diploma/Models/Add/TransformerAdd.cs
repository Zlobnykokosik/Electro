using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.Models.Add
{
    [Index(nameof(Name), IsUnique = true)]
    public class TransformerAdd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int ID { get; set; }
        [StringLength(50)] public required string Name { get; set; }
        public required bool Type { get; set; }
        public required string Address { get; set; }
        public required int Сoefficient { get; set; }
        public DateOnly СommissioningDate { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public virtual MountTrasformer? MountTrasformers { get; set; }
        public bool IsClosed { get; set; }
        public DateOnly? CloseDate { get; set; } = null;

    }
}


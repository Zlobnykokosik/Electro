using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.Models.Add
{
    public class MountTrasformer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string? TransformerName { get; set; }
        public int? TransformerAddId { get; set; }
        public virtual List<TransformerAdd>? TransformerAdds { get; set; }
        public int? PointAddId { get; set; }
        public virtual List<PointAdd>? PointAdds { get; set; }
        public required DateOnly SetDate { get; set; }
        public bool IsClosed { get; set; }
        public DateOnly? CloseDate { get; set; } = null;
    }
}

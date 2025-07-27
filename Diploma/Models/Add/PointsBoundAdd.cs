using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.Models.Add
{
    public class PointsBoundAdd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public required int ID { get; set; }
        [ForeignKey("PointBase")]
        public required int  PointIDBase { get; set; }
        public required virtual PointAdd PointBase { get; set; }
        [ForeignKey("PointMinus")]
        public required int  PointIDMinus { get; set; }
        public required virtual PointAdd PointMinus { get; set; }
    }
}

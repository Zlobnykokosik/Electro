using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.Models.Add
{
    [Index(nameof(ReadingDate), nameof(MountMeterAddID), IsUnique = true)]
    public class ReadingAdd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public uint Month {  get; set; } 
        public required DateOnly ReadingDate { get; set; }
        public required float Reading {  get; set; }
        public int? MountMeterAddID { get; set; }
        public MountMeterAdd? MountMeterAdd { get; set; } 
    }
}

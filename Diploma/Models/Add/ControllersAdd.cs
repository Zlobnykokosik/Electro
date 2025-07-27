using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.Models.Add
{
    [Index(nameof(ContollerNum), IsUnique = true)]
    public class ControllersAdd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int ID { get; set; }
        public required int ContollerNum { get; set; }
        [StringLength(150)] 
        public required string FIO { get; set; }
        public required virtual List<AbonentAdd> AbonentAdds { get; set; } = [];
    }
}

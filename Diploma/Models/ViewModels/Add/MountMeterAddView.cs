using Microsoft.AspNetCore.Mvc.Rendering;

namespace Diploma.Models.ViewModels.Add
{
    public class MountMeterAddView
    {
        public required string SelectedMeterId { get; set; }
        public required string SelectedUnitsId { get; set; }
        public List<SelectListItem>? Units { get; set; }
        public List<SelectListItem>? Meters { get; set; }
        public required string Type { get; set; }
        public DateOnly SetDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}

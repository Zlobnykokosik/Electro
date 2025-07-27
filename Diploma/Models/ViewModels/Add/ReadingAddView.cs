using Microsoft.AspNetCore.Mvc.Rendering;

namespace Diploma.Models.ViewModels.Add
{
    public class ReadingAddView
    {
        public required string SelectedMeterId { get; set; }
        public List<SelectListItem>? MountMeters { get; set; }
        public required uint Month { get; set; } 
        public required DateOnly ReadingDate { get; set; }
        public required float Reading { get; set; }
    }
}

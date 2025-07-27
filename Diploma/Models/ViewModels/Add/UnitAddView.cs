using Microsoft.AspNetCore.Mvc.Rendering;

namespace Diploma.Models.ViewModels.Add
{
    public class UnitAddView
    {
        public required string SelectedPointId { get; set; }
        public List<SelectListItem>? Points { get; set; }
    }
}

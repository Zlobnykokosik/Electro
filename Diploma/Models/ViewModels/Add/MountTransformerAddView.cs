using Microsoft.AspNetCore.Mvc.Rendering;

namespace Diploma.Models.ViewModels.Add
{
    public class MountTransformerAddView
    {
        public required string SelectedTransformerId { get; set; }
        public required string SelectedPointId { get; set; }
        public List<SelectListItem>? Points { get; set; }
        public List<SelectListItem>? Transformers { get; set; }
        public DateOnly SetDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}

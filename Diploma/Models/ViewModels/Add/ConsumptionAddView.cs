using Microsoft.AspNetCore.Mvc.Rendering;

namespace Diploma.Models.ViewModels.Add
{
    public class ConsumptionAddView
    {
        public required string SelectedPointId { get; set; }
        public List<SelectListItem>? Points { get; set; }
        public required uint Month { get; set; }
        public required DateOnly ConsumptionDate { get; set; }
        public required float Consumption { get; set; }
    }
}

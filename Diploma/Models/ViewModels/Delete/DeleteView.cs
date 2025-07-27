using Microsoft.AspNetCore.Mvc.Rendering;

namespace Diploma.Models.ViewModels.Delete
{
    public class DeleteView
    {
        public  string? SelectedContractId { get; set; }
        public List<SelectListItem>? ContractNumbers { get; set; }
        public string? SelectedAbonentId { get; set; }
        public List<SelectListItem>? AbonentNumbers { get; set; }
        public string? SelectedPointId { get; set; }
        public List<SelectListItem>? PointNumbers { get; set; }
        public string? SelectedUnitId { get; set; }
        public List<SelectListItem>? UnitNumbers { get; set; }
        public string? SelectedMountMetersId { get; set; }
        public List<SelectListItem>? MountMetersNumbers { get; set; }
        public string? SelectedMountTransformerId { get; set; }
        public List<SelectListItem>? MountTransformerNumbers { get; set; }
    }
}

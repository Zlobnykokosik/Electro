using Diploma.Models.Add;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.Contracts;

namespace Diploma.Models.ViewModels.Add
{
    public class AbonentAddView
    {
        public required string SelectedContractId { get; set; }
        public required string SelectedControllertId { get; set; }
        public List<SelectListItem>? ContractNumbers { get; set; }
        public List<SelectListItem>? ControllersNumbers { get; set; }
        public required int AbonentNumber { get; set; }
        public required DateOnly ConclusionDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public required string Address { get; set; }
        public required string Name { get; set; }

    }
}

using Diploma.Models.Add;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace Diploma.Models.ViewModels.Add
{
    public class PointAddView
    {
        public required string SelectedContractId { get; set; }
        public List<SelectListItem>? ContractNumbers { get; set; }
        public required string SelectedAbonentId { get; set; }
        public List<SelectListItem>? AbonentNumbers { get; set; }
        public required int PointNumber { get; set; }
        public required string Location { get; set; }
        public VersionType Version { get; set; }
        public CalcType Type { get; set; }
        public enum CalcType
        {
            [Display(Name = "Статичный расход")]
            CalcStatic,
            [Display(Name = "Связанные ТУ")]
            CalcBounds,
            [Display(Name = "Простой")]
            CalcComman,
        }
        public enum VersionType
        {
            [Display(Name = "Расчетная")]
            Calc,
            [Display(Name = "Контрольная")]
            Control,
            [Display(Name = "Тех учет")]
            Tech,
        }
    }
}

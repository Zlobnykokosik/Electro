using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Diploma.Models.ViewModels.Add
{
    public class TransformerAddView
    {
        public required string Name { get; set; }
        public required string Type { get; set; }
        public required string Address { get; set; }
        public required int Сoefficient { get; set; }
        public DateOnly СommissioningDate  { get; set; } = DateOnly.FromDateTime(DateTime.Today);
    }
}

using Diploma.Models;
using Diploma.Models.Add;
using Diploma.Models.ViewModels.Add;
using Diploma.Models.ViewModels.Arhive;
using Diploma.Models.ViewModels.Delete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace Diploma.Controllers
{
    public class DeleteController(MyDbContext context) : Controller
    {
        private readonly MyDbContext _dbContext = context;

        public IActionResult Delete()
        {
            var model = new DeleteView
            {
                SelectedAbonentId = "",
                SelectedContractId = "",
                SelectedMountMetersId = "",
                SelectedMountTransformerId = "",
                SelectedPointId = "",
                SelectedUnitId = "",
                ContractNumbers = _dbContext.Contracts.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.ContractNumber.ToString()
                }).ToList(),
                AbonentNumbers = _dbContext.Abonents.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.AbonentNumber.ToString()
                }).ToList(),
                PointNumbers = _dbContext.Points.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.Number.ToString()
                }).ToList(),
                UnitNumbers = _dbContext.Units.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.ID.ToString()
                }).ToList(),
                MountMetersNumbers = _dbContext.MountMeters.Include(a => a.MeterAdd).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.MeterAdd.Number.ToString()
                }).ToList(),
                MountTransformerNumbers = _dbContext.MountTrasformers.Include(a => a.TransformerAdds).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.TransformerName.ToString()
                }).ToList(),
            };
            return View(model);
        }
        [HttpPost]
#pragma warning disable CS8604 
        public async Task<IActionResult> DeleteObjects(DeleteView deleteView)
        {

            if (deleteView.SelectedContractId != null && deleteView.SelectedAbonentId == null)
            {
                var contract = _dbContext.Contracts.Include(a => a.Abonents).Where(a => a.ID == int.Parse(deleteView.SelectedContractId)).FirstOrDefault();
                foreach (var abonent in contract.Abonents)
                {
                    _dbContext.Abonents.Remove(abonent);
                }
                _dbContext.Contracts.Remove(contract);

            }
            if (deleteView.SelectedAbonentId != null && deleteView.SelectedContractId != null)
            {
                var contract = _dbContext.Contracts.Where(a => a.ID == int.Parse(deleteView.SelectedContractId)).Include(a => a.Abonents).FirstOrDefault();
                var abonent = contract?.Abonents?.FirstOrDefault(a => a.ID == int.Parse(deleteView.SelectedAbonentId));
                foreach (var point in abonent.Points)
                {
                    _dbContext.Points.Remove(point);
                }
                _dbContext.Abonents.Remove(abonent);

            }
            if (deleteView.SelectedPointId != null)
            {
                var point = _dbContext.Points.Where(a => a.ID == int.Parse(deleteView.SelectedPointId)).FirstOrDefault();
                _dbContext.Points.Remove(point);
            }
            if (deleteView.SelectedUnitId != null)
            {
                var unit = _dbContext.Units.Where(a => a.ID == int.Parse(deleteView.SelectedUnitId)).FirstOrDefault();
                _dbContext.Units.Remove(unit);
            }
            if (deleteView.SelectedMountMetersId != null)
            {
                var mountMeter = _dbContext.MountMeters.Where(a => a.ID == int.Parse(deleteView.SelectedMountMetersId)).FirstOrDefault();
                _dbContext.MountMeters.Remove(mountMeter);
            }
            if (deleteView.SelectedMountTransformerId != null)
            {
                var mountTrasformer = _dbContext.MountTrasformers.Where(a => a.ID == int.Parse(deleteView.SelectedMountTransformerId)).FirstOrDefault();
                _dbContext.MountTrasformers.Remove(mountTrasformer);
            }
            if (ModelState.IsValid)
            {
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Delete));
            }
            return View("Delete");
        }
#pragma warning restore CS8604
        public JsonResult LoadSecondListDeleteAbonents(string SelectedContractId)
        {
            var secondListData = _dbContext.Abonents.Where(a => a.ContractAddId == int.Parse(SelectedContractId))
                .Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.AbonentNumber.ToString()
                }).ToList();

            return Json(secondListData);
        }
    }
}

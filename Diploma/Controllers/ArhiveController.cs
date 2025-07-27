using Diploma.Models;
using Diploma.Models.ViewModels.Arhive;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Diploma.Controllers
{
    public class ArhiveController(MyDbContext context) : Controller
    {
        private readonly MyDbContext _dbContext = context;

        public IActionResult ToArhive()
        {
            var model = new ArhiveView
            {
                SelectedAbonentId = "",
                SelectedContractId = "",
                SelectedMountMetersId = "",
                SelectedMountTransformerId = "",
                SelectedPointId = "",
                SelectedUnitId = "",
                CloseDate = DateOnly.FromDateTime(DateTime.Now),
                ContractNumbers = _dbContext.Contracts.Where(a=>!a.IsClosed).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.ContractNumber.ToString()
                }).ToList(),
                AbonentNumbers = _dbContext.Abonents.Where(a => !a.IsClosed).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.AbonentNumber.ToString()
                }).ToList(),
                PointNumbers = _dbContext.Points.Where(a => !a.IsClosed).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.Number.ToString()
                }).ToList(),
                UnitNumbers = _dbContext.Units.Where(a => !a.IsClosed).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.ID.ToString()
                }).ToList(),
                MountMetersNumbers = _dbContext.MountMeters.Include(a => a.MeterAdd).Where(a => !a.IsClosed).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.MeterAdd.Number.ToString()
                }).ToList(),
                MountTransformerNumbers = _dbContext.MountTrasformers.Include(a => a.TransformerAdds).Where(a => !a.IsClosed).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.TransformerName.ToString()
                }).ToList(),
            };
            return View(model);
        }
        [HttpPost]
#pragma warning disable CS8602
        public async Task<IActionResult> MakeArhive(ArhiveView arhiveView)
        {
            if (ModelState.IsValid)
            {
                if (arhiveView.SelectedContractId != null && arhiveView.SelectedAbonentId == null)
                {
                    var contract = _dbContext.Contracts.Include(a=>a.Abonents).Where(a => a.ID == int.Parse(arhiveView.SelectedContractId)).FirstOrDefault();
                    contract.CloseDate = arhiveView.CloseDate;
                    contract.IsClosed = true;
                    foreach (var abonent in contract.Abonents)
                    {
                        abonent.IsClosed = true;
                        abonent.CloseDate = arhiveView.CloseDate;

                    }
                }
                if (arhiveView.SelectedAbonentId != null && arhiveView.SelectedContractId != null)
                {
                    var contract = _dbContext.Contracts.Where(a => a.ID == int.Parse(arhiveView.SelectedContractId)).Include(a => a.Abonents).FirstOrDefault();
                    var abonent = contract?.Abonents?.FirstOrDefault(a => a.ID == int.Parse(arhiveView.SelectedAbonentId));
                    abonent.CloseDate = arhiveView.CloseDate;
                    abonent.IsClosed = true;
                }
                if (arhiveView.SelectedPointId != null)
                {
                    var point = _dbContext.Points.Where(a => a.ID == int.Parse(arhiveView.SelectedPointId)).FirstOrDefault();
                    point.CloseDate = arhiveView.CloseDate;
                    point.IsClosed = true;
                }
                if (arhiveView.SelectedUnitId != null)
                {
                    var unit = _dbContext.Units.Where(a => a.ID == int.Parse(arhiveView.SelectedUnitId)).FirstOrDefault();
                    unit.CloseDate = arhiveView.CloseDate;
                    unit.IsClosed = true;
                }
                if (arhiveView.SelectedMountMetersId != null)
                {
                    var mountMeter = _dbContext.MountMeters.Where(a => a.ID == int.Parse(arhiveView.SelectedMountMetersId)).FirstOrDefault();
                    mountMeter.CloseDate = arhiveView.CloseDate;
                    mountMeter.IsClosed = true;
                }
                if (arhiveView.SelectedMountTransformerId != null)
                {
                    var mountTrasformer = _dbContext.MountTrasformers.Where(a => a.ID == int.Parse(arhiveView.SelectedMountTransformerId)).FirstOrDefault();
                    mountTrasformer.CloseDate = arhiveView.CloseDate;
                    mountTrasformer.IsClosed = true;
                }
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(ToArhive));
            }
            return View("ToArhive");
        }

        public IActionResult FromArhive()
        {
            var model = new ArhiveView
            {
                SelectedAbonentId = "",
                SelectedContractId = "",
                SelectedMountMetersId = "",
                SelectedMountTransformerId = "",
                SelectedPointId = "",
                SelectedUnitId = "",
                CloseDate = DateOnly.FromDateTime(DateTime.Now),
                ContractNumbers = _dbContext.Contracts.Where(a => a.IsClosed).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.ContractNumber.ToString()
                }).ToList(),
                AbonentNumbers = _dbContext.Abonents.Where(a => a.IsClosed).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.AbonentNumber.ToString()
                }).ToList(),
                PointNumbers = _dbContext.Points.Where(a => a.IsClosed).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.Number.ToString()
                }).ToList(),
                UnitNumbers = _dbContext.Units.Where(a => a.IsClosed).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.ID.ToString()
                }).ToList(),
                MountMetersNumbers = _dbContext.MountMeters.Include(a => a.MeterAdd).Where(a => a.IsClosed).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.MeterAdd.Number.ToString()
                }).ToList(),
                MountTransformerNumbers = _dbContext.MountTrasformers.Include(a => a.TransformerAdds).Where(a => a.IsClosed).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.TransformerName.ToString()
                }).ToList(),
            };
            return View(model);
        }
        [HttpPost]

        public async Task<IActionResult> OpenFromArhive(ArhiveView arhiveView)
        {
            if (ModelState.IsValid)
            {
                if (arhiveView.SelectedContractId != null && arhiveView.SelectedAbonentId == null)
                {
                    var contract = _dbContext.Contracts.Include(a=>a.Abonents).Where(a => a.ID == int.Parse(arhiveView.SelectedContractId)).FirstOrDefault();
                    contract.CloseDate = null;
                    contract.IsClosed = false;
                    foreach (var abonent in contract.Abonents)
                    {
                        abonent.IsClosed = false;
                        abonent.CloseDate = null;

                    }
                }
                if (arhiveView.SelectedAbonentId != null && arhiveView.SelectedContractId != null)
                {
                    var contract = _dbContext.Contracts.Where(a => a.ID == int.Parse(arhiveView.SelectedContractId)).Include(a => a.Abonents).FirstOrDefault();
                    var abonent = contract?.Abonents?.FirstOrDefault(a => a.ID == int.Parse(arhiveView.SelectedAbonentId));

                    abonent.CloseDate = null;

                    abonent.IsClosed = false;
                }
                if (arhiveView.SelectedPointId != null)
                {
                    var point = _dbContext.Points.Where(a => a.ID == int.Parse(arhiveView.SelectedPointId)).FirstOrDefault();
                    point.CloseDate = null;
                    point.IsClosed = false;
                }
                if (arhiveView.SelectedUnitId != null)
                {
                    var unit = _dbContext.Units.Where(a => a.ID == int.Parse(arhiveView.SelectedUnitId)).FirstOrDefault();
                    unit.CloseDate = null;  
                    unit.IsClosed = false;
                }
                if (arhiveView.SelectedMountMetersId != null)
                {
                    var mountMeter = _dbContext.MountMeters.Where(a => a.ID == int.Parse(arhiveView.SelectedMountMetersId)).FirstOrDefault();
                    mountMeter.CloseDate = null;
                    mountMeter.IsClosed = false;
                }
                if (arhiveView.SelectedMountTransformerId != null)
                {
                    var mountTrasformer = _dbContext.MountTrasformers.Where(a => a.ID == int.Parse(arhiveView.SelectedMountTransformerId)).FirstOrDefault();
                    mountTrasformer.CloseDate = null;
                    mountTrasformer.IsClosed = false;
                }
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(FromArhive));
            }
            return View("FromArhive");
        }
#pragma warning restore CS8602 
        [HttpGet]
        public JsonResult LoadSecondListOpenedAbonents(string SelectedContractId)
        {
            var secondListData = _dbContext.Abonents.Where(a => a.ContractAddId == int.Parse(SelectedContractId) && !a.IsClosed)
                .Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.AbonentNumber.ToString()
                }).ToList();

            return Json(secondListData);
        }

        [HttpGet]
        public JsonResult LoadSecondListClosedAbonents(string SelectedContractId)
        {
            var secondListData = _dbContext.Abonents.Where(a => a.ContractAddId == int.Parse(SelectedContractId) && a.IsClosed)
                .Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.AbonentNumber.ToString()
                }).ToList();

            return Json(secondListData);
        }
    }

}

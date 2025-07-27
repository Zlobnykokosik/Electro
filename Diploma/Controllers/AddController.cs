using Diploma.Models;
using Diploma.Models.Add;
using Diploma.Models.Check;
using Diploma.Models.ViewModels.Add;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace Diploma.Controllers
{
    public class AddController(MyDbContext context) : Controller
    {
        private readonly MyDbContext _dbContext = context;

        public IActionResult Contract()

        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateContract(ContractAdd contract)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Contracts.Add(contract);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Contract));
            }
            return View("Contract");
        }

        public IActionResult Abonent()
        {
            var model = new AbonentAddView
            {
                SelectedContractId = "",
                SelectedControllertId = "",
                Name = "",
                AbonentNumber = 0,
                Address = "",
                ConclusionDate = DateOnly.FromDateTime(DateTime.Now),
                ContractNumbers = _dbContext.Contracts.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.ContractNumber.ToString()
                }).ToList(),
                ControllersNumbers = _dbContext.ControllersAdds.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.ContollerNum.ToString()
                }).ToList()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbonent(AbonentAddView abonent)
        {
            var data = new AbonentAdd
            {
                Name = abonent.Name,
                AbonentNumber = abonent.AbonentNumber,
                Address = abonent.Address,
                ConclusionDate = abonent.ConclusionDate,
                ContractAddId = int.Parse(abonent.SelectedContractId),
                ControllersAddId = int.Parse(abonent.SelectedControllertId)
            };

            if (ModelState.IsValid)
            {
                _dbContext.Abonents.Add(data);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Abonent));
            }
            return View("Abonent");
        }
        public IActionResult Meter()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMeter(MeterAdd meter)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Meters.Add(meter);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Meter));
            }
            return View("Meter");
        }

        public IActionResult Point()
        {
            var model = new PointAddView
            {
                SelectedAbonentId = "",
                SelectedContractId = "",
                Location = "",
                PointNumber = 0,
                ContractNumbers = _dbContext.Contracts.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.ContractNumber.ToString()
                }).ToList(),
                AbonentNumbers = _dbContext.Abonents.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.AbonentNumber.ToString()
                }).ToList()


            };
            return View(model);
        }

        [HttpGet]
        public JsonResult LoadSecondListPoint(string SelectedContractId)
        {
            var secondListData = _dbContext.Abonents.Where(a => a.ContractAddId == int.Parse(SelectedContractId))
                .Select(a => new SelectListItem
            {
                Value = a.ID.ToString(),
                Text = a.AbonentNumber.ToString()
            }).ToList();

            return Json(secondListData);
        }


        [HttpPost]
        public async Task<IActionResult> CreatePoint(PointAddView point)
        {
            var data = new PointAdd
            {
                Type = (CalcType)point.Type,
                Version = (VersionType)point.Version,
                Number = point.PointNumber,
                Location = point.Location,
                //ContractAddId = int.Parse(point.SelectedContractId),
                AbonentAddId = int.Parse(point.SelectedAbonentId)
            };
            if (ModelState.IsValid)
            {
                _dbContext.Points.Add(data);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Point));
            }
            return View("Point");
        }

        public IActionResult Transformer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTransformer(TransformerAdd transformer)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Transformers.Add(transformer);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Transformer));
            }
            return View("Transformer");
        }


        public IActionResult Unit()
        {
            var model = new UnitAddView
            {
                SelectedPointId = "",
                Points = _dbContext.Points.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.Number.ToString()
                }).ToList()
            };
            return View(model);
        }

        [HttpGet]
        public JsonResult LoadSecondListMeter( bool type)
        {
            var secondListData = _dbContext.Meters.Where(a => a.Active == type)
                .Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.Number.ToString()
                }).ToList();

            return Json(secondListData);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUnit(UnitAddView unit)
        {
            var data = new UnitAdd
            {
                PointAddId = int.Parse(unit.SelectedPointId)
            };
            if (ModelState.IsValid)
            {
                _dbContext.Units.Add(data);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Unit));
            }
            return View("Unit");
        }

        public IActionResult Controller()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateController(ControllersAdd controllers)
        {
            if (ModelState.IsValid)
            {
                _dbContext.ControllersAdds.Add(controllers);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Controller));
            }
            return View("Controller");
        }
        public IActionResult MountMeter()
        {
            var model = new MountMeterAddView
            {
                SelectedMeterId = "",
                SelectedUnitsId = "",
                Units = _dbContext.Units.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.ID.ToString()
                }).ToList(),
                Meters = _dbContext.Meters.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.Number.ToString()
                }).ToList(),
                Type = ""
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SetMeter(MountMeterAddView mountMeterAdd)
        {
            var data = new MountMeterAdd
            {
                Active = bool.Parse(mountMeterAdd.Type),
                MeterAddID = int.Parse(mountMeterAdd.SelectedMeterId),
                UnitAddID = int.Parse(mountMeterAdd.SelectedUnitsId),
                SetDate = mountMeterAdd.SetDate,

            };
            if (ModelState.IsValid)
            {
                _dbContext.MountMeters.Add(data);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(MountMeter));
            }
            return View("MountMeter");
        }

        public IActionResult MountTransformer()
        {
            var model = new MountTransformerAddView
            {
                SelectedPointId = "",
                SelectedTransformerId = "",
                Points = _dbContext.Points.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.ID.ToString()
                }).ToList(),
                Transformers = _dbContext.Transformers.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.Name.ToString()
                }).ToList(),
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SetTrasnformer(MountTransformerAddView mountTransformerAdd)
        {
            var data = new MountTrasformer
            {
                SetDate = mountTransformerAdd.SetDate,
                PointAddId = int.Parse(mountTransformerAdd.SelectedPointId),
                TransformerAddId = int.Parse(mountTransformerAdd.SelectedTransformerId),
                TransformerName = _dbContext.Transformers.Where(a=>a.ID == int.Parse(mountTransformerAdd.SelectedTransformerId)).Select(a=>a.Name).FirstOrDefault(),
            };
            if (ModelState.IsValid)
            {
                _dbContext.MountTrasformers.Add(data);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(MountTransformer));
            }
            return View("MountTransformer");
        }
        public IActionResult Reading()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var lastDayOfMonth = today.AddDays(DateTime.DaysInMonth(today.Year, today.Month) - today.Day);

            var model = new ReadingAddView
            {
                SelectedMeterId = "",
                Month = (uint)DateTime.Now.Month,
                MountMeters = _dbContext.MountMeters.Include(a=>a.MeterAdd).Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.MeterAdd.Number.ToString()
                }).ToList(),
                ReadingDate = lastDayOfMonth,
                Reading = 0
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddReading(ReadingAddView readingAddView)
        {
            var data = new ReadingAdd
            {
                ReadingDate = readingAddView.ReadingDate,
                MountMeterAddID = int.Parse(readingAddView.SelectedMeterId),
                Month = readingAddView.Month,
                Reading = readingAddView.Reading,
            };
            if (ModelState.IsValid)
            {
                _dbContext.ReadingAdds.Add(data);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Reading));
            }
            return View("Reading");
        }

        public IActionResult Consumption()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var lastDayOfMonth = today.AddDays(DateTime.DaysInMonth(today.Year, today.Month) - today.Day);

            var model = new ConsumptionAddView
            {
                SelectedPointId = "",
                Month = (uint)DateTime.Now.Month,
                Points = _dbContext.Points.Select(a => new SelectListItem
                {
                    Value = a.ID.ToString(),
                    Text = a.Number.ToString()
                }).ToList(),
                ConsumptionDate = lastDayOfMonth,
                Consumption = 0
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddConsumption(ConsumptionAddView consumptionAdd)
        {
            var data = new ConsumptionAdd
            {
                ConsumptionDate = consumptionAdd.ConsumptionDate,
                PointAddID = int.Parse(consumptionAdd.SelectedPointId),
                Month = consumptionAdd.Month,
                Consumption = consumptionAdd.Consumption,
            };
            if (ModelState.IsValid)
            {
                _dbContext.ConsumptionAdds.Add(data);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Consumption));
            }
            return View("Consumption");
        }
    }

}

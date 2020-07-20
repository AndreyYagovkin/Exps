using Exps.Common.Services;
using Exps.WebClient.Areas.Journal.Models;
using Exps.WebClient.Areas.Journal.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exps.WebClient.Areas.MasterData.Controllers
{
    [Area("MasterData")]
    public class JournalController : Controller
    {
        private readonly IJournalService _journalService;

        private readonly IDateTimeService _dateTimeService;

        public JournalController(IJournalService journalService,
            IDateTimeService dateTimeService)
        {
            _journalService = journalService;
            _dateTimeService = dateTimeService;
        }

        public IActionResult Index()
        {
            var today = _dateTimeService.Today();

            ViewBag.JournalFilterParams = new JournalFilterParams
            {
                Date = today
            };

            var records = _journalService.GetRecords(today);

            var model = new JournalModel
            {
                Records = records,
                AddRecord = new AddRecordModel {Date = today}
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(JournalFilterParams filterParams)
        {
            ViewBag.JournalFilterParams = filterParams;

            var records = _journalService.GetRecords(filterParams.Date);

            var model = new JournalModel
            {
                Records = records,
                AddRecord = new AddRecordModel {Date = filterParams.Date}
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(JournalModel model)
        {
            if (ModelState.IsValid)
            {
                _journalService.AddRecord(model.AddRecord);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(int id)
        {
            _journalService.DeleteRecord(id);
            return RedirectToAction("Index");
        }
    }
}
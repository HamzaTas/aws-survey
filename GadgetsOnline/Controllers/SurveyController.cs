namespace GadgetsOnline.Controllers
{
    using GadgetsOnline.Models;
    using GadgetsOnline.Services;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    public class SurveyController : Controller
    {
        private ISurveyService surveyService;

        public SurveyController(ISurveyService _surveyService)
        {
            surveyService = _surveyService;
        }

        //Inventory inventory;
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetQuestion()
        {
            var result = surveyService.GetSurveyQuestions();

            return this.Json(result);
        }
    }
}
namespace GadgetsOnline.Services
{
    using GadgetsOnline.Models;
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;

    public interface ISurveyService
    {
        List<SurveyQuestion> GetSurveyQuestions();
    }
}
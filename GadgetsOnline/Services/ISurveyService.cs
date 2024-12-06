namespace GadgetsOnline.Services
{
    using GadgetsOnline.Models;
    using System.Collections.Generic;

    public interface ISurveyService
    {
        Hotel GetRandomHotel();

        SurveyMainModel GetHotelSurveyQuestions();

        bool SendQuestionData(List<SurveyAnswerResponse> data);

        List<SurveyAnswerResponse> GenerateRandomData();
    }
}
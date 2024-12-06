namespace GadgetsOnline.Services
{
    using GadgetsOnline.Models;

    public interface ISurveyService
    {
        Hotel GetRandomHotel();

        SurveyMainModel GetHotelSurveyQuestions();
    }
}
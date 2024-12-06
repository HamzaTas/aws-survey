using System.Collections.Generic;

namespace GadgetsOnline.Models
{
    public class SurveyMainModel
    {
        public int HotelId { get; set; }

        public string HotelName {  get; set; }

        public List<SurveyQuestion> SurveyQuestions { get; set; }
    }
}

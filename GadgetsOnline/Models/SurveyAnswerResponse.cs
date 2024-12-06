namespace GadgetsOnline.Models
{
    public class SurveyAnswerResponse
    {
        public int HotelId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public int EmotionalValue { get; set; } // Kullanıcı yorumları için opsiyonel alan
    }

}

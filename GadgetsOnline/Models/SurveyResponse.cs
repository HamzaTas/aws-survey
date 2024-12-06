namespace GadgetsOnline.Models
{
    public class SurveyResponse
    {
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public string Comment { get; set; } // Kullanıcı yorumları için opsiyonel alan
    }

}

namespace GadgetsOnline.Models
{
    using System.ComponentModel.DataAnnotations;

    public class SurveyAnswerResponse
    {
        [Key]
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public int EmotionalValue { get; set; } // Kullanıcı yorumları için opsiyonel alan
    }
}

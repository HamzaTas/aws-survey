namespace GadgetsOnline.Models
{
    using System.Collections.Generic;

    public class SurveyQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public List<SurveyAnswer> Answers { get; set; }
    }
}

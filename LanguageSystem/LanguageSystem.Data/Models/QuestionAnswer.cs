namespace LanguageSystem.Data.Models
{
    public class QuestionAnswer
    {
        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
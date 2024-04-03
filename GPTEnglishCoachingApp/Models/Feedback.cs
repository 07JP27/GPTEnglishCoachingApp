namespace GPTEnglishCoachingApp.Models
{
    public class Feedback
    {
        public int TargetMsgIndex { get; set; }
        public FeedbackTypeEnum Type { get; set; }= FeedbackTypeEnum.Other;
        public string Content { get; set; }= string.Empty;
    }
}
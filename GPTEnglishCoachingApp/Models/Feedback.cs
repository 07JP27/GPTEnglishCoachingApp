using System.Text.Json.Serialization;

namespace GPTEnglishCoachingApp.Models
{
    public class Feedback
    {
        public int TargetMsgIndex { get; set; }
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FeedbackTypeEnum Type { get; set; }= FeedbackTypeEnum.Other;
        [JsonPropertyName("content")]
        public string Content { get; set; }= string.Empty;
    }
}
using System.Text.Json.Serialization;

namespace GPTEnglishCoachingApp.Models
{
    public class FreeChatResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }= string.Empty;

        [JsonPropertyName("feedbacks")]
        public List<Feedback> Feedbacks { get; set; }= new List<Feedback>();
    }
}
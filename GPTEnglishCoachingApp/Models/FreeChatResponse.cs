using System.Text.Json.Serialization;

namespace GPTEnglishCoachingApp.Models
{
    public class FreeChatResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }= string.Empty;

        [JsonPropertyName("feedback")]
        public List<Feedback> Feedback { get; set; }= new List<Feedback>();
    }
}
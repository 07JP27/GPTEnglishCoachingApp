using System.Text.Json.Serialization;

namespace GPTEnglishCoachingApp.Models
{
    public class ToeicExamQuestion
    {
        [JsonPropertyName("questions")]
        public List<ToeicExamQuestionItem> Questions { get; set; }= new List<ToeicExamQuestionItem>();
    }

    public class ToeicExamQuestionItem
    {
        public int Index { get; set; }

        [JsonPropertyName("question")]
        public string Question { get; set; }= string.Empty;

        [JsonPropertyName("options")]
        public List<ToeicExamQuestionOptionItem> Options { get; set; }= new List<ToeicExamQuestionOptionItem>();

        [JsonPropertyName("targetLevel")]
        public int TargetLevel { get; set; }

        public string UserAnswer { get; set; }= string.Empty;

        public string Answer { 
            get =>Options.FirstOrDefault(option => option.IsAnswer)?.Key ?? string.Empty;
        }

        public bool IsCorrect { 
            get =>Answer == UserAnswer;
        }
    }

    public class ToeicExamQuestionOptionItem
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }= string.Empty;

        [JsonPropertyName("option")]
        public string Option { get; set; }= string.Empty;

        [JsonPropertyName("isAnswer")]
        public bool IsAnswer { get; set; }
    }
}
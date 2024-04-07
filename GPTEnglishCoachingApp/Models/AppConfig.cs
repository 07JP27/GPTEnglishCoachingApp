namespace GPTEnglishCoachingApp.Models
{
    public class AppConfig
    {
        public const string SectionName = "App";
        public string OpenAIEndpoint { get; set; } = string.Empty;
        public string OpenAIDeployment { get; set; } = string.Empty;
    }
}
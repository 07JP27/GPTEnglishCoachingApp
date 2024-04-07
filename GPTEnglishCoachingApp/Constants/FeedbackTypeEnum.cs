using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter<FeedbackTypeEnum>))]
public enum FeedbackTypeEnum
{
    Grammar,
    Vocabulary,
    Other
}

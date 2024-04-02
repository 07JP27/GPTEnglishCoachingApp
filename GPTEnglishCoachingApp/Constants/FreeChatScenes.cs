public static class FreeChatScenes
{
    public static List<FreeChatScene> SceneList = new List<FreeChatScene>
    {
        new FreeChatScene
        {
            SceneId = "1",
            SceneName = "Free Chat",
            SceneDescriptionPrompt = "Please talk about anything you like."
        },
        new FreeChatScene
        {
            SceneId = "2",
            SceneName = "Immigration",
            SceneDescriptionPrompt ="Please talk about your experience with"
        },
        new FreeChatScene
        {
            SceneId = "3",
            SceneName = "Check-in at the airport",
            SceneDescriptionPrompt ="Please talk about your experience with"
        },
        new FreeChatScene
        {
            SceneId = "4",
            SceneName = "Check-in at the hotel",
            SceneDescriptionPrompt ="Please talk about your experience with"
        },
    };
}

public class FreeChatScene
{
    public string SceneId { get; set; } = string.Empty;
    public string SceneName { get; set; } = string.Empty;
    public string SceneDescriptionPrompt { get; set; } = string.Empty;
}
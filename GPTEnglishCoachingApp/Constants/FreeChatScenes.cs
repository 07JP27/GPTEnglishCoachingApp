public static class FreeChatScenes
{
    public static List<FreeChatScene> SceneList = new List<FreeChatScene>
    {
        /*
        new FreeChatScene
        {
            SceneId = "1",
            SceneName = "Free Chat",
            SceneDescriptionPrompt = """Please talk about anything you like."""
        },
        */
        new FreeChatScene
        {
            SceneId = "2",
            SceneName = "Immigration",
            SceneDescriptionPrompt ="""
            Reproduce a conversation at an immigration checkpoint in the United States.
            You: Immigration Officer.Have a conversation to complete the immigration process.
            User: Traveler trying to enter the country.
            """
        },
        new FreeChatScene
        {
            SceneId = "3",
            SceneName = "Check-in at the airport",
            SceneDescriptionPrompt ="""
            Recreate the conversation at boarding check-in at the airport.
            You: Airline receptionist. Please have a conversation to complete the boarding process.
            User: Traveler about to check-in.
            """
        },
        new FreeChatScene
        {
            SceneId = "4",
            SceneName = "Check-in at the hotel",
            SceneDescriptionPrompt ="""
            Reproduce the conversation at check-in at a hotel.
            You: The hotel receptionist. Please have a conversation to complete the check-in process.
            User: Traveler about to check-in
            """
        },
    };
}

public class FreeChatScene
{
    public string SceneId { get; set; } = string.Empty;
    public string SceneName { get; set; } = string.Empty;
    public string SceneDescriptionPrompt { get; set; } = string.Empty;
}
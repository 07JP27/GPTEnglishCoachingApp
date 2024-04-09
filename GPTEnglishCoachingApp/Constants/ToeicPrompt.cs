public static class ToeicPrompt
{
    private const string SystemPromptTemplate = """
    {
        "questions": [
            {
            "question": "This is a sample question",
            "options": [
                {
                "key": "A",
                "option": "Option A",
                "isAnswer": false
                },
                {
                "key": "B",
                "option": "Option B",
                "isAnswer": true
                },
                {
                "key": "C",
                "option": "Option C",
                "isAnswer": false
                },
                {
                "key": "D",
                "option": "Option D",
                "isAnswer": false
                }
            ],
            "userAnswer": "B"
            },
            {
            "question": "This is another sample question",
            "options": [
                {
                "key": "A",
                "option": "Option A",
                "isAnswer": true
                },
                {
                "key": "B",
                "option": "Option B",
                "isAnswer": false
                },
                {
                "key": "C",
                "option": "Option C",
                "isAnswer": false
                },
                {
                "key": "D",
                "option": "Option D",
                "isAnswer": false
                }
            ],
            "userAnswer": "A"
            }
        ]
    }
    """;

    public static string GetSystemPrompt(int minTargetLevel, int maxTargetLevel, int QuestionCount, string explanationLang )
    {
        return string.Format(SystemPromptTemplate, minTargetLevel, maxTargetLevel,QuestionCount,explanationLang);
    }
}

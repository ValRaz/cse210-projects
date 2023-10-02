using System;

public class PromptGenerator {
    public List<string> Prompts {get;}

    public PromptGenerator() {
        Prompts = new List<string> {
            "Write about a positive experience you had today",
            "Write about an experience where you felt the spirit with you today",
            "Write about something that happened for which you are grateful today",
            "Write about something you did today that showed Christlike love",
            "Write about an act of service you performed today",
            "Write about something you learned today",
            "Write about a tender mercy you noticed today",
            "Write about a positive interaction you had with someone else today",
            "Write about something you noticed that reminded you of Jesus Christ today",
            "Write about something you learned about someone in your life today",
            "Write about an experience you had that allowed you to teach someone else today"
        };
    }

    //Generates a random prompt from the list
    public string GenerateRandomPrompt() {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        return Prompts[index];
    }
}
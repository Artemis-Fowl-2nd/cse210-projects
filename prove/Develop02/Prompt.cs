// prompts by chat gpt
public class Prompt
{
    public static List<string> _prompts =  new List<string>{
    "What are three things you're grateful for today?",
    "Describe a recent challenge you overcame.",
    "What is one goal you want to achieve this week?",
    "Write about a moment that made you feel happy recently.",
    "What is something new you learned today?",
    "Reflect on a time when you felt proud of yourself.",
    "What does your ideal day look like?",
    "Write about someone who inspires you and why.",
    "How do you handle stress, and what can you improve?",
    "What is a habit you'd like to develop, and why?"
    };
    
    public static string Display()
    {
        Random rnd = new Random();
        int target = rnd.Next(0,_prompts.Count());
        Console.WriteLine($"{_prompts[target]}");
        return _prompts[target];
    }
    
    
}
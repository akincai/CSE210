public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What did I improve about myself today?");
        _prompts.Add("What can I do better tomorrow?");
    }

    public string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }
}
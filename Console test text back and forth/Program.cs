// this code should be called 𝕄𝕚𝕟𝕚 𝕔𝕠𝕟𝕤𝕠𝕝𝕖
using System.Net;
{
    Console.Title = ("𝕄𝕚𝕟𝕚 𝕔𝕠𝕟𝕤𝕠𝕝𝕖");
    Console.WriteLine("whats your name");
    Console.ReadLine();
    Console.WriteLine("nice mine is 𝕄𝕚𝕟𝕚 𝕔𝕠𝕟𝕤𝕠𝕝𝕖");
    Console.WriteLine("how old are you");
    string age = Console.ReadLine();
    int userage = Int32.Parse(age);
    if (userage >= 18)
    {
        Console.WriteLine("You're an adult.");
        Console.Clear();
    }
    else if (userage >= 13)
    {
        Console.WriteLine("You're a teenager.");
        Console.Clear();

    }
    else
    {
        Console.Beep();
        Console.WriteLine("YOUR UNDERAGE");
        Console.WriteLine("Press the enter key to exit.");
        Console.ReadKey();
    }
    Console.WriteLine("How may I assist you?");
    string userInput = Console.ReadLine();

    while (!string.IsNullOrWhiteSpace(userInput))
    {
        string answer = GetAnswer(userInput);
        Console.WriteLine("Answer: " + answer);

        Console.WriteLine("How else may I assist you?");
        userInput = Console.ReadLine();
    }
}

static string GetAnswer(string question)
{
    switch (question.ToLower())
    {
        case "what is your name":
            return "I am " +
                "𝕄𝕚𝕟𝕚 𝕔𝕠𝕟𝕤𝕠𝕝𝕖";
        case "tell me a joke":
            return "Why don't scientists trust atoms? Because they make up everything!";
        case "how's the weather today?":
            return "I'm sorry, I don't have access to real-time data.";
        case "whats 2+2":
            return "4";
        default:
            return "I'm not sure how to answer that question.";
        case "no":
            return ("Press the enter key to exit.");
            Console.ReadKey();
    }
}

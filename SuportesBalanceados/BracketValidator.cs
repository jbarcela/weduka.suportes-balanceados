namespace SuportesBalanceados;

public class BracketValidator
{
    private readonly char[] openingBrackets = { '(', '[', '{' };
    private readonly char[] closingBrackets = { ')', ']', '}' };

    public bool IsValid(string bracketsSequence)
    {
        var stack = new Stack<char>();

        foreach (var bracket in bracketsSequence)
        {
            if (IsOpeningBracket(bracket))
            {
                stack.Push(bracket);
            }
            else if (IsClosingBracket(bracket))
            {
                if (stack.Count == 0 || !AreMatchingBrackets(stack.Peek(), bracket))
                {
                    return false;
                }
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }
    
    private bool IsOpeningBracket(char c)
    {
        return Array.IndexOf(openingBrackets, c) != -1;
    }

    private bool IsClosingBracket(char c)
    {
        return Array.IndexOf(closingBrackets, c) != -1;
    }
    
    private bool AreMatchingBrackets(char openingBracket, char closingBracket)
    {
        var openingIndex = Array.IndexOf(openingBrackets, openingBracket);
        var closingIndex = Array.IndexOf(closingBrackets, closingBracket);

        return openingIndex == closingIndex;
    }
}
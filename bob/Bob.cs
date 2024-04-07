using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        // Clean string
        string cleanStatement = statement.Trim();
        
        // Verify if statement contain letters and if all chars are Upper
        static bool IsAllUpperCase(string text) => text.Any(char.IsLetter) && text == text.ToUpper();
        
        // Get last char of statement
        char lastChar = cleanStatement.Length > 0 ? cleanStatement[cleanStatement.Length - 1] : 'O';

        if (IsAllUpperCase(cleanStatement) && lastChar == '?')
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (IsAllUpperCase(cleanStatement))
        {
            return "Whoa, chill out!";
        }
        else if (lastChar == '?')
        {
            return "Sure.";
        }
        else if (string.IsNullOrWhiteSpace(cleanStatement))
        {
            return "Fine. Be that way!";
        }
        else { return "Whatever."; }
    }
}
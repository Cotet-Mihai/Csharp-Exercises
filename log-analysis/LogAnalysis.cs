using System;
using System.Linq;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string parameter)
    {
        int index = str.IndexOf(parameter);
        
        return (index >= 0) ? str.Substring(index + parameter.Length) : string.Empty;
    }

    public static string SubstringBetween(this string str, string firstParameter, string secondParameter)
    {
        int firstIndex = str.IndexOf(firstParameter);
        int secondIndex = str.IndexOf(secondParameter);

        if (firstIndex >= 0 && secondIndex > 0)
        {
            return str.Substring(firstIndex + firstParameter.Length, secondIndex - (firstIndex + firstParameter.Length));
        }
        else { return string.Empty; }
    }
    
    public static string Message(this string str) => str.SubstringAfter(": ");

    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}
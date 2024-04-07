using System;
using System.ComponentModel.Design;
using System.Reflection.Emit;

static class LogLine
{
    public static string Message(string logLine)
    {
        int indexOfSpace = logLine.IndexOf(' '); // take first space
        if (indexOfSpace != -1) // check if exist space
        {
            string message = logLine.Substring(indexOfSpace + 1); // get the message after space
            return message.Trim(); // clean string
        }
        else { return "error"; } // return error
    }

    public static string LogLevel(string logLine)
    {
        // if contains level we need return the level Tolower
        if (logLine.Contains("ERROR")) { return "error"; }
        else if (logLine.Contains("WARNING")) { return "warning"; }
        else if (logLine.Contains("INFO")) { return "info"; }
        else { return "error"; }
    }

    public static string Reformat(string logLine)
    {
        // We use our functions to reverse level with message
        string message = Message(logLine);
        string level = $"({LogLevel(logLine)})";

        return $"{message} {level}";
    }
}

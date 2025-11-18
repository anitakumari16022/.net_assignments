using System;

delegate void FormatText(string text);

class TextFormatter
{
    static void ToUpperCase(string s)
    {
        Console.WriteLine("Uppercase: " + s.ToUpper());
    }

    static void ToLowerCase(string s)
    {
        Console.WriteLine("Lowercase: " + s.ToLower());
    }

    static void Main()
    {
        FormatText fmt = ToUpperCase;
        fmt += ToLowerCase;

        fmt("Hello World");
    }
}

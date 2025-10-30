using System;
using System.IO;

delegate void ProcessData(string data);

class DelegateExample
{
    static void DisplayData(string data)
    {
        Console.WriteLine("Displaying Data: " + data);
    }

    static void LogData(string data)
    {
        string filePath = "log.txt";
        File.AppendAllText(filePath, data + Environment.NewLine);
        Console.WriteLine("Data logged to file: " + filePat

using System;

delegate void Notifier(string message);

class NotificationSystem
{
    static void SendEmail(string msg)
    {
        Console.WriteLine("Email Sent: " + msg);
    }

    static void SendSMS(string msg)
    {
        Console.WriteLine("SMS Sent: " + msg);
    }

    static void Main()
    {
        Notifier notify = SendEmail;
        notify += SendSMS;

        notify("Assignment Submitted Successfully!");
    }
}

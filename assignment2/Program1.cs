using System;

class UserProfile
{
    private string username;
    private string password;
    private string email;

    public string Username
    {
        get { return username; }
        set { username = value; }
    }

    public string Password
    {
        get { return password; }
        set
        {
            if (value.Length >= 6)
                password = value;
            else
                Console.WriteLine("Password must be at least 6 characters long.");
        }
    }

    public string Email
    {
        get { return email; }
        set
        {
            if (value.Contains("@"))
                email = value;
            else
                Console.WriteLine("Invalid email address.");
        }
    }

    public void Display()
    {
        Console.WriteLine($"Username: {username}, Email: {email}");
    }
}

class Experiment1
{
    static void Main()
    {
        UserProfile user1 = new UserProfile();
        user1.Username = "Alice";
        user1.Password = "pass12";
        user1.Email = "alice@example.com";
        user1.Display();

        UserProfile user2 = new UserProfile();
        user2.Username = "Bob";
        user2.Password = "123"; // invalid
        user2.Email = "bobexample.com"; // invalid
        user2.Display();
    }
}

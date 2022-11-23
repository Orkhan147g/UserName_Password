internal class User
{
    private string _username;
    private protected string Username;
    private string _password;
    private protected string Password;

    public User(string username, string password)
    {
        Username = username;
        Password = password;

    }
    public void ShowInfo()
    {
        Console.Write("Username: ");
        string user = Console.ReadLine();
        Username = user;
        if (user.Length > 6)
        {
            Passwword();
            _username = user;
        }
        else
        {
            Console.WriteLine("Try again");
            ShowInfo();
        }
    }
    public void Passwword()
    {
        Console.Write("Password: ");U
        string kod = Console.ReadLine();
        Password = kod;
        if (kod == kod.ToLower())
        {
            Console.WriteLine("Set again Password");
            Passwword();
        }
        else
        {
            _password = kod;
        }
    }

}


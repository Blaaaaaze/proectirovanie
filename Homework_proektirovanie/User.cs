using System;

public abstract class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Login()
    {
        Console.WriteLine("{0} вошел в аккаунт", Name);
    }

    public void Logout()
    {
        Console.WriteLine("{0} вышел из аккаунта", Name);
    }
}

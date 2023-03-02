
using System;
using System.Collections.Generic;
using System.Security.Principal;

public sealed class Account
{
    public string Name { get; }
    public string Email { get; }
    public string Password { get; }
    public Account(string name, string password, string email)
    {
        Name = name;
        Password = password;
        Email = email;
    }
    public override string ToString()
    {
        return $"Name: {Name}{Environment.NewLine}" +
               $"Email: {Email}{Environment.NewLine}" +
               $"Password: {Password}{Environment.NewLine}" +
               new string('-', 10);
    }

}

public static class NoobDb
{
    public static void Add(Account account) { }
    public static Account? SearchByEmail(string email) { }
    public static void PrintAll() { }
    public static void Remove(Account account) { }
};


public class MainClass
{
    public static void Main()
    {
        //reading data from console
        var listData = new List<string>();
        string input = Console.ReadLine();
        while (input != "end")
        {
            listData.Add(input);
            input = Console.ReadLine();
        }

        //data processing
        for (int i = 0; i < listData.Count; i++)
        {
            string[] line = listData[i].Split(' ');
            if (line.Length == 3)
            {
                if (line[0].Length >= 4 && passCheck(line[1]) && emailCheck(line[2]))
                {
                    if (NoobDb.SearchByEmail(line[2]) == null)
                    {
                        NoobDb.Add(new Account(line[0], line[1], line[2]));
                    }
                }
            }
        }
        NoobDb.PrintAll();
    }

    public static bool passCheck(string input)
    {
        bool isDigit = false;
        bool isLowLetter = false;
        bool isHighLetter = false;
        if (input.Length >= 6)
        {
            foreach (char x in input)
            {
                isDigit = Char.IsNumber(x) || isDigit;
                isLowLetter = Char.IsLower(x) || isLowLetter;
                isHighLetter = Char.IsUpper(x) || isHighLetter;
            }
        }
        return isDigit && isLowLetter && isHighLetter;
    }

    public static bool emailCheck(string input)
    {
        bool res = false;
        var listChar = new List<char>(input);
        if (listChar.IndexOf('@') != -1 && listChar.IndexOf('@') == listChar.LastIndexOf('@'))
        {
            if (listChar.IndexOf('.') != -1 && listChar.IndexOf('@') == listChar.LastIndexOf('@'))
            {
                if (listChar.IndexOf('.') - listChar.LastIndexOf('@') > 1)
                {
                    if (listChar.IndexOf('@') - 0 > 1 && listChar.Count - 1 - listChar.IndexOf('.') > 1)
                    {
                        res = true;
                    }
                }
            }
        }
        return res;
    }
}

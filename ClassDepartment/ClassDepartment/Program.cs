using System;
using System.Collections.Generic;
using System.Text;

public class Department
{
    public Department()
    {
        staff = 0;
        tugriki = 0;
        coffee = 0;
        pages = 0;
        tugrOnPage = 0;
        name = "";
    }

    public Department(Department dep1, Department dep2, Department dep3, Department dep4)
    {
        staff = dep1.staff + dep2.staff + dep3.staff + dep4.staff;
        tugriki = dep1.tugriki + dep2.tugriki + dep3.tugriki + dep4.tugriki;
        coffee = dep1.coffee + dep2.coffee + dep3.coffee + dep4.coffee;
        pages = dep1.pages + dep2.pages + dep3.pages + dep4.pages;
        tugrOnPage = Math.Round((double)tugriki / pages, 2, MidpointRounding.AwayFromZero);
        name = "Всего";
    }

    private int staff { get; set; }
    private int tugriki { get; set; }
    private int coffee { get; set; }
    private int pages { get; set; }
    private string name { get; set; }
    private double tugrOnPage { get; set; }

    public void Add(int amount, string role, int level, int leader)
    {
        staff += amount;
        switch (role)
        {
            case "manager":
                tugriki += (int)Math.Round((50000 + 50000 * (level - 1) * 0.25 + (50000 + 50000 * (level - 1) * 0.25) * 0.5 * leader) * amount);
                coffee += (20 + (20 * leader)) * amount;
                pages += (200 - 200 * leader) * amount;
                break;

            case "marketer":
                tugriki += (int)Math.Round((40000 + 40000 * (level - 1) * 0.25 + (40000 + 40000 * (level - 1) * 0.25) * 0.5 * leader) * amount);
                coffee += (15 + (15 * leader)) * amount;
                pages += (150 - 150 * leader) * amount;
                break;

            case "engineer":
                tugriki += (int)Math.Round((20000 + 20000 * (level - 1) * 0.25 + (20000 + 20000 * (level - 1) * 0.25) * 0.5 * leader) * amount);
                coffee += (5 + (5 * leader)) * amount;
                pages += (50 - 50 * leader) * amount;
                break;

            case "analyst":
                tugriki += (int)Math.Round((80000 + 80000 * (level - 1) * 0.25 + (80000 + 80000 * (level - 1) * 0.25) * 0.5 * leader) * amount);
                coffee += (50 + (50 * leader)) * amount;
                pages += (5 - 5 * leader) * amount;
                break;
        }
        tugrOnPage = Math.Round((double)tugriki / pages, 2, MidpointRounding.AwayFromZero);
    }

    public void AddName(string name)
    {
        name = name.Substring(0, name.Length - 1);
        char[] temp = name.ToCharArray();
        temp[0] = char.ToUpper(temp[0]);
        this.name = new string(temp);
    }

    public string Print(StringBuilder sb)
    {
        string res = "";
        int index = 0;
        int resLength = 0;
        string[] arr = new string[] { "Сотрудников", "Тугрики", "Кофе", "Страницы", "Тугр./стр." };
        res += name;
        for (int i = 0; i < arr.Length; i++)
        {
            index = sb.ToString().IndexOf(arr[i]);
            resLength = res.Length;
            for (int j = 0; j < index - resLength; j++)
            {
                res += ' ';
            }
            if (i == arr.Length - 1)
            {
                res += tugrOnPage.ToString() + '\n';
            }
            else
            {
                switch (i)
                {
                    case 0:
                        res += staff.ToString();
                        break;
                    case 1:
                        res += tugriki.ToString();
                        break;
                    case 2:
                        res += coffee.ToString();
                        break;
                    case 3:
                        res += pages.ToString();
                        break;
                }
            }
        }
        return res;
    }
}
public class MainClass
{
    public static string[] Parsing(string str)
    {
        var result = new string[3];
        int startIndex = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsNumber(str[i]) && i == 0)
            {
                result[0] = str.Substring(0, str.IndexOf('*') - 0);
                i = str.IndexOf('*');
                startIndex = i + 1;
            }
            else if (i == 0)
            {
                result[0] = "1";
                startIndex = 0;
            }
            else if (char.IsNumber(str[i]))
            {
                result[1] = str.Substring(startIndex, i - startIndex);
                result[2] = str[i].ToString();
                break;
            }
        }
        return result;
    }

    public static void Main()
    {
        var list = new List<Department>();
        string input;
        for (int j = 0; j < 4; j++)
        {
            input = Console.ReadLine();
            int isLeader = 0;
            string[] strArray = input.Split(' ');
            list.Add(new Department());
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Contains("руководитель"))
                {
                    isLeader = 1;
                }
                else if (strArray[i].Contains("закупок") || strArray[i].Contains("продаж") || strArray[i].Contains("рекламы") || strArray[i].Contains("логистики"))
                {
                    list[list.Count - 1].AddName(strArray[i]);
                }
                else if (strArray[i].Contains("manager") || strArray[i].Contains("marketer") || strArray[i].Contains("engineer") || strArray[i].Contains("analyst"))
                {
                    var str = Parsing(strArray[i]);
                    list[list.Count - 1].Add(int.Parse(str[0]), str[1], int.Parse(str[2]), isLeader);
                }
            }
        }
        list.Add(new Department(list[0], list[1], list[2], list[3]));

        var sb = new StringBuilder();
        int lengthRow = 0;
        string separator = "";
        int iter = 0;
        for (int i = 0; i < 8; i++)
        {
            switch (i)
            {
                case 0:
                    sb.Append("Департамент     Сотрудников     Тугрики     Кофе     Страницы     Тугр./стр.\n");
                    lengthRow = sb.Length;
                    for (int j = 1; j < lengthRow; j++)
                    {
                        separator += '-';
                    }
                    separator += '\n';
                    break;
                case 1:
                case 6:
                    sb.Append(separator);
                    break;
                default:
                    sb.Append(list[iter].Print(sb));
                    iter++;
                    break;
            }
        }
        Console.WriteLine(sb);
    }
}
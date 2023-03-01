using System;

public class Date
{
    public Date(int day, int month, int year)
    {
        int tmpYear = year < 1 ? 1 : year;
        int tmpMonth = month < 1 ? 1 : month;
        int tmpDay = day < 1 ? 1 : day;

        //month to year
        if (tmpMonth % 12 != 0)
        {
            tmpYear += tmpMonth / 12;
            tmpMonth = tmpMonth % 12;
        }
        else
        {
            tmpYear += tmpMonth / 12 - 1;
            tmpMonth = 12;
        }

        //day to year
        while (tmpDay > 365 && tmpYear % 4 != 0 || tmpDay > 366 && tmpYear % 4 == 0)
        {
            if (tmpDay > 365 && tmpYear % 4 != 0)
            {
                tmpDay -= 365;
                tmpYear++;
            }
            else
            {
                tmpDay -= 366;
                tmpYear++;
            }
        }

        // day to month
        while (tmpDay > DaysInMonth(tmpMonth, tmpYear))
        {
            tmpDay -= DaysInMonth(tmpMonth, tmpYear);
            tmpMonth++;
            if (tmpMonth > 12)
            {
                tmpYear++;
                tmpMonth -= 12;
            }
        }

        this.year = tmpYear;
        this.month = tmpMonth;
        this.day = tmpDay;
    }

    public Date Next()
    {
        var res = new Date(day + 1, month, year);
        return res;
    }

    public Date Previous()
    {
        if (day == 1)
        {
            if (month == 1)
            {
                if (year == 1)
                {
                    return new Date(day, month, year);
                }
                else
                {
                    return new Date(DaysInMonth(12, year), 12, year - 1);
                }
            }
            else
            {
                return new Date(DaysInMonth(month - 1, year), month - 1, year);
            }
        }
        else
        {
            return new Date(day - 1, month, year);
        }
    }

    public void Print()
    {
        Console.WriteLine($"The {day} of {NameOfMonth(month)} {year}");
    }

    public void PrintForward(int n)
    {
        var temp = Next();
        for (int i = 0; i < n; i++)
        {
            temp.Print();
            temp = temp.Next();
        }
    }

    public void PrintBackward(int n)
    {
        var temp = Previous();
        for (int i = 0; i < n; i++)
        {
            temp.Print();
            temp = temp.Previous();
        }
    }

    private int DaysInMonth(int n, int year)
    {
        switch (n)
        {
            case 1:
                return 31;
            case 2:
                if (year % 4 == 0)
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            case 3:
                return 31;
            case 4:
                return 30;
            case 5:
                return 31;
            case 6:
                return 30;
            case 7:
                return 31;
            case 8:
                return 31;
            case 9:
                return 30;
            case 10:
                return 31;
            case 11:
                return 30;
            case 12:
                return 31;
            default:
                return 0;
        }
    }

    private string NameOfMonth(int n)
    {
        switch (n)
        {
            case 1:
                return "January";
            case 2:
                return "February";
            case 3:
                return "March";
            case 4:
                return "April";
            case 5:
                return "May";
            case 6:
                return "June";
            case 7:
                return "July";
            case 8:
                return "August";
            case 9:
                return "September";
            case 10:
                return "October";
            case 11:
                return "November";
            case 12:
                return "December";
            default:
                return "";
        }
    }

    private int day;
    private int month;
    private int year;
}

public class MainClass
{
    public static void Main()
    {
        var date = new Date(31, 14, 2000);
        date.Print();
        date.Next().Print();
        date.Previous().Print();
        date.PrintForward(5);
        date.PrintBackward(5);
    }
}
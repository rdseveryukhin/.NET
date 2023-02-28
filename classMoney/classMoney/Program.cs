using System;

public class Money
{
    public Money(string val, string cur)
    {
        if (int.Parse(val) < 0)
        {
            Console.WriteLine("Can't be negative!");
        }
        else
        {
            if (cur == "коп.")
            {
                kop = int.Parse(val) % 100;
                rub = int.Parse(val) / 100;
            }
            else
            {
                rub = int.Parse(val);
                kop = 0;
            }
        }
    }

    public Money(string val1, string cur1, string val2, string cur2)
    {
        if (int.Parse(val1) < 0 || int.Parse(val2) < 0)
        {
            Console.WriteLine("Can't be negative!");
        }
        else if (cur1 == "cop.")
        {
            Console.WriteLine("Rubles and copes mixed!");
        }
        else
        {
            rub = int.Parse(val1);
            kop = int.Parse(val2) % 100;
            rub += int.Parse(val2) / 100;
        }
    }

    public static Money Sum(Money a, Money b)
    {
        int tmpRub = 0;
        int tmpKop = 0;
        tmpRub = a.rub + b.rub;
        tmpKop = (a.kop + b.kop) % 100;
        tmpRub += (a.kop + b.kop) / 100;
        return new Money(tmpRub.ToString(), "r.", tmpKop.ToString(), "cop.");
    }

    public static Money Difference(Money a, Money b)
    {
        int tmpRub = 0;
        int tmpKop = 0;
        tmpRub = a.rub - b.rub;
        if (a.kop >= b.kop)
        {
            tmpKop = a.kop - b.kop;
        }
        else
        {
            tmpKop = 100 + (a.kop - b.kop);
            tmpRub -= 1;
        }
        return new Money(tmpRub.ToString(), "r.", tmpKop.ToString(), "cop.");
    }

    public void Print()
    {
        if (rub == 0)
        {
            Console.WriteLine($"{kop} cop.");
        }
        else
        {
            Console.WriteLine($"{rub} r. {kop} cop.");
        }
    }

    public void PrintTransferCost(double p)
    {
        double temp = rub * 100 + kop;
        temp = temp + temp * p;
        temp = Math.Round(temp);
        int res = (int)temp;
        if (res < 100)
        {
            Console.WriteLine($"{temp} cop.");
        }
        else
        {
            Console.WriteLine($"{res / 100} r. {res % 100} cop.");
        }
    }

    public int rub;
    public int kop;
}

public class MainClass
{
    public static void Main()
    {

    }
}
using System;

public class Viewer
{
    public Viewer(int price, int amount)
    {
        this.price = price;
        this.amount = amount;
    }

    public virtual void Print()
    {
        double sum = (double)price * amount;
        Console.WriteLine(sum);
    }

    public int price;
    public int amount;
}

public class Regular : Viewer
{
    public Regular(int price, int amount, int nums) : base(price, amount) => this.nums = nums;

    public int nums;

    public override void Print()
    {
        int sale = 0;
        double sum = 0;
        for (int i = nums + 1; i <= amount + nums; i++)
        {
            if (i > 200)
            {
                sale = 20;
            }
            else
            {
                sale = i / 10;
            }
            sum += price - price / 100.0 * sale;
        }
        sum = Math.Round(sum, 2);
        Console.WriteLine(sum);
    }
}

public class Student : Viewer
{
    public Student(int price, int amount, int nums) : base(price, amount) => this.nums = nums;

    public int nums;

    public override void Print()
    {
        int sale = 0;
        double sum = 0;
        for (int i = nums + 1; i <= amount + nums; i++)
        {
            if (i % 3 == 0)
            {
                sale = 50;
            }
            else
            {
                sale = 0;
            }
            sum += price - price / 100.0 * sale;
        }
        sum = Math.Round(sum, 2);
        Console.WriteLine(sum);
    }
}

public class Pensioner : Viewer
{
    public Pensioner(int price, int amount, int nums) : base(price, amount) => this.nums = nums;

    public int nums;

    public override void Print()
    {
        int sale = 0;
        double sum = 0;
        for (int i = nums + 1; i <= amount + nums; i++)
        {
            if (i % 5 == 0)
            {
                sale = 100;
            }
            else
            {
                sale = 50;
            }
            sum += price - price / 100.0 * sale;
        }
        sum = Math.Round(sum, 2);
        Console.WriteLine(sum);
    }
}

public class MainClass
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        if (input[0] == "viewer")
        {
            var temp = new Viewer(int.Parse(input[2]), int.Parse(input[3]));
            temp.Print();
        }
        else if (input[0] == "regular")
        {
            var temp = new Regular(int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[1]));
            temp.Print();
        }
        else if (input[0] == "student")
        {
            var temp = new Student(int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[1]));
            temp.Print();
        }
        else if (input[0] == "pensioner")
        {
            var temp = new Pensioner(int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[1]));
            temp.Print();
        }
    }
}

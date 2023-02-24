using System;

public class Insect
{
    public Insect(double[] arr)
    {
        x = arr[0];
        y = arr[1];
        z = arr[2];
    }

    public double x;
    public double y;
    public double z;
}

public class MainClass
{
    public static double PrintDistance(Insect fly, Insect spider)
    {
        double result = Math.Sqrt(Math.Pow((spider.x - fly.x), 2) + Math.Pow((spider.y - fly.y), 2) + Math.Pow((spider.z - fly.z), 2));
        result = Math.Abs(result);
        result = Math.Round(result, 5);
        return result;
    }

    public static double PrintPath(Insect fly, Insect spider)
    {
        double result = Math.Abs(Math.Sqrt(Math.Pow(spider.x - fly.x, 2) + Math.Pow(spider.y - fly.y, 2))) + (spider.z - fly.z);
        result = Math.Round(result, 5);
        return result;
    }

    public static void Main()
    {
        var s1 = Console.ReadLine().Split(' ');
        var s2 = Console.ReadLine().Split(' ');

        double[] arrFly = new double[s1.Length];
        for (int i = 0; i < s1.Length; i++)
        {
            arrFly[i] = double.Parse(s1[i]);
        }

        double[] arrSpider = new double[s2.Length];
        for (int i = 0; i < s2.Length; i++)
        {
            arrSpider[i] = double.Parse(s2[i]);
        }

        if (arrFly[2] > 0)
        {
            Console.WriteLine($"Fly must be on a floor!");
        }
        else
        {
            var fly = new Insect(arrFly);
            var spider = new Insect(arrSpider);

            Console.WriteLine("Distance: " + PrintDistance(fly, spider));
            Console.WriteLine("Path: " + PrintPath(fly, spider));
        }
    }
}
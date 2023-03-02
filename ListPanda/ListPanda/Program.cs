using System;
using System.Collections.Generic;

public class Panda
{
    public Panda(double x, double y, string gender)
    {
        this.x = x;
        this.y = y;
        this.gender = gender;
    }

    public double x;
    public double y;
    public string gender;
}

public class Pair
{
    public Pair(Panda male, Panda female, double distance)
    {
        this.male = male;
        this.female = female;
        this.distance = distance;
    }

    public Panda male;
    public Panda female;
    public double distance;
}

public class MainClass
{
    public static void Main()
    {
        //reading data from console
        int pandasCount = 0;
        var malePandas = new List<Panda>();
        var femalePandas = new List<Panda>();
        string input = Console.ReadLine();
        while (input != "end")
        {
            pandasCount++;
            string[] tempstr = input.Split(' ');
            Panda temp = new Panda(double.Parse(tempstr[0]), double.Parse(tempstr[1]), tempstr[2]);
            if (temp.gender == "male")
            {
                malePandas.Add(temp);
            }
            else
            {
                femalePandas.Add(temp);
            }
            input = Console.ReadLine();
        }

        //data processing
        var listPair = new List<Pair>();
        double tmp;
        double minVal = 0;
        int maleIndex = 0;
        int femaleIndex = 0;
        while (malePandas.Count != 0 && femalePandas.Count != 0)
        {
            minVal = double.MaxValue;
            for (int i = 0; i < malePandas.Count; i++)
            {
                for (int j = 0; j < femalePandas.Count; j++)
                {
                    tmp = Math.Round(Math.Sqrt(Math.Pow(femalePandas[j].x - malePandas[i].x, 2) + Math.Pow(femalePandas[j].y - malePandas[i].y, 2)), 2);
                    if (tmp < minVal)
                    {
                        minVal = tmp;
                        maleIndex = i;
                        femaleIndex = j;
                    }
                }
            }
            listPair.Add(new Pair(malePandas[maleIndex], femalePandas[femaleIndex], minVal));
            malePandas.RemoveAt(maleIndex);
            femalePandas.RemoveAt(femaleIndex);
        }

        //data output
        Console.WriteLine($"Total pandas count: {pandasCount}");
        if (malePandas.Count != 0)
        {
            for (int i = 0; i < malePandas.Count; i++)
            {
                Console.WriteLine($"Lonely {malePandas[i].gender} panda at X: {malePandas[i].x}, Y: {malePandas[i].y}");
            }
        }
        else if (femalePandas.Count != 0)
        {
            for (int i = 0; i < femalePandas.Count; i++)
            {
                Console.WriteLine($"Lonely {femalePandas[i].gender} panda at X: {femalePandas[i].x}, Y: {femalePandas[i].y}");
            }
        }
        if (listPair.Count != 0)
        {
            for (int i = 0; i < listPair.Count; i++)
            {
                Console.WriteLine($"Pandas pair at distance {listPair[i].distance}, male panda at X: {listPair[i].male.x}, Y: {listPair[i].male.y}, female panda at X: {listPair[i].female.x}, Y: {listPair[i].female.y}");
            }
        }
    }
}
using System;

public class MainClass
{
    public static void ArraySort(int[] array, out int[] arr1, out int[] arr2)
    {
        int temp = 0;
        arr1 = new int[array.Length];
        arr2 = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            arr1[i] = array[i];
            arr2[i] = array[i];
        }

        for (int i = 1; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr1.Length - i; j++)
            {
                if (arr1[j] > arr1[j + 1])
                {
                    temp = arr1[j];
                    arr1[j] = arr1[j + 1];
                    arr1[j + 1] = temp;
                }
            }
        }

        for (int i = 1; i < arr2.Length; i++)
        {
            for (int j = 0; j < arr2.Length - i; j++)
            {
                if (arr2[j] < arr2[j + 1])
                {
                    temp = arr2[j];
                    arr2[j] = arr2[j + 1];
                    arr2[j + 1] = temp;
                }
            }
        }
    }

    public static void Main()
    {
        string[] str_arr = Console.ReadLine().Split(' ');
        int[] array = new int[str_arr.Length];
        for (int i = 0; i < str_arr.Length; i++)
        {
            array[i] = int.Parse(str_arr[i]);
        }
        ArraySort(array, out int[] arr1, out int[] arr2);
        foreach (var x in arr1)
            Console.Write(x + " ");
        foreach (var x in arr2)
            Console.Write(x + " ");
    }
}
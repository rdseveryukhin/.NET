using System;

public class Matrix
{
    public Matrix()
    {
        row = 0;
        col = 0;
        data = new double[row, col];
    }

    public void Read()
    {
        var input = Console.ReadLine().Split(' ');
        int[] arr = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        row = arr[0];
        col = arr[1];
        double[,] temp = new double[row, col];

        for (int i = 0; i < row; i++)
        {
            var inData = Console.ReadLine().Split(' ');
            for (int j = 0; j < inData.Length; j++)
            {
                temp[i, j] = double.Parse(inData[j]);
            }
        }
        data = temp;
    }

    public void Write()
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (j == col - 1)
                {
                    Console.Write(data[i, j]);
                }
                else
                {
                    Console.Write(data[i, j] + " ");
                }
            }
            Console.Write('\n');
        }
    }

    public Matrix Multiply(double n)
    {
        var res = new Matrix();
        res.row = row;
        res.col = col;
        double[,] temp = new double[res.row, res.col];
        res.data = temp;
        for (int i = 0; i < res.row; i++)
        {
            for (int j = 0; j < res.col; j++)
            {
                res.data[i, j] = data[i, j] * n;
            }
        }
        return res;
    }

    public Matrix Sum(Matrix other)
    {
        var res = new Matrix();
        res.row = row;
        res.col = col;
        double[,] temp = new double[res.row, res.col];
        res.data = temp;
        if (col == other.col && row == other.row)
        {
            for (int i = 0; i < res.row; i++)
            {
                for (int j = 0; j < res.col; j++)
                {
                    res.data[i, j] = data[i, j] + other.data[i, j];
                }
            }
        }
        return res;
    }

    public Matrix Increase(Matrix other)
    {
        var res = new Matrix();
        res.row = row;
        res.col = col;
        res.data = data;

        if (res.col == other.row && other.col == res.row)
        {
            double[,] temp = new double[res.row, other.col];
            for (int i = 0; i < res.row; i++)
            {
                for (int j = 0; j < other.col; j++)
                {
                    for (int c = 0; c < res.col; c++)
                    {
                        temp[i, j] += res.data[i, c] * other.data[c, j];
                    }
                }
            }
            res.data = temp;
            res.col = other.col;
        }

        return res;
    }

    public Matrix Transpose()
    {
        var res = new Matrix();
        res.row = col;
        res.col = row;
        double[,] temp = new double[res.row, res.col];
        res.data = temp;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                res.data[j, i] = data[i, j];
            }
        }
        return res;
    }

    public int row;
    public int col;
    public double[,] data;
}

public class MainClass
{
    public static void Main()
    {
        var A = new Matrix();
        A.Read();
        A.Transpose().Write();
    }
}

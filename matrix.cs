using System;
using System.Text;

public class Matrix
{
    private int[,] data;

    public Matrix(int size)
    {
        data = new int[size, size];
    }

    public int this[int i, int j]
    {
        get
        {
            return data[i, j];
        }
        set
        {
            data[i, j] = value;
        }
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (m1.data.GetLength(0) != m2.data.GetLength(0) || m1.data.GetLength(1) != m2.data.GetLength(1))
        {
            throw new ArgumentException("The matrices must be the same size.");
        }

        var result = new Matrix(m1.data.GetLength(0));
        for (int i = 0; i < m1.data.GetLength(0); i++)
        {
            for (int j = 0; j < m1.data.GetLength(1); j++)
            {
                result[i, j] = m1[i, j] + m2[i, j];
            }
        }
        return result;
    }

    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        if (m1.data.GetLength(0) != m2.data.GetLength(0) || m1.data.GetLength(1) != m2.data.GetLength(1))
        {
            throw new ArgumentException("The matrices must be the same size.");
        }

        var result = new Matrix(m1.data.GetLength(0));
        for (int i = 0; i < m1.data.GetLength(0); i++)
        {
            for (int j = 0; j < m1.data.GetLength(1); j++)
            {
                result[i, j] = m1[i, j] - m2[i, j];
            }
        }
        return result;
    }



    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                sb.Append(data[i, j] + "\t");
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
}
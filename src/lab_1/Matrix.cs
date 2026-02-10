namespace lab_1;

public class Matrix
{
    private readonly int[,] _data;
    public int Rows { get; }
    public int Cols { get; }

    public Matrix(int[,] data)
    {
        _data = data ?? throw new ArgumentNullException(nameof(data));
        Rows = data.GetLength(0);
        Cols = data.GetLength(1);
    }

    public Matrix Xor(Matrix other)
    {
        ValidateDimensions(other);
        int[,] result = new int[Rows, Cols];

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                result[i, j] = _data[i, j] ^ other._data[i, j];
            }
        }
        return new Matrix(result);
    }

    private void ValidateDimensions(Matrix other)
    {
        if (other == null) throw new ArgumentNullException(nameof(other));
        if (Rows != other.Rows || Cols != other.Cols)
        {
            throw new ArgumentException("Matrices must have the same dimensions");
        }
    }

    public double[] GetAverage()
    {
        double[] averages = new double[Cols];

        for (int j = 0; j < Cols; j++)
        {
            double sum = 0;
            for (int i = 0; i < Rows; i++) sum += _data[i, j];
            averages[j] = sum / Rows;
        }
        return averages;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Matrix other) return false;
        if (Rows != other.Rows || Cols != other.Cols) return false;

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                if (_data[i, j] != other._data[i, j]) return false;
            }
        }
        return true;
    }

    public override int GetHashCode() => HashCode.Combine(Rows, Cols, _data);

    public void PrintMatrix()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
                Console.Write(_data[i, j].ToString().PadLeft(4));
            Console.WriteLine();
        }
    }
}
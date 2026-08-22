namespace SabakaLib;

public class Matrix<T>(int rows, int columns)
{
    private readonly T[,] _matrix = new T[rows, columns];

    public T this[int row, int column]
    {
        get => _matrix[row, column];
        set => _matrix[row, column] = value;
    }
    
    public override string ToString()
    {
        var sb = new System.Text.StringBuilder();
        for (int r = 0; r < _matrix.GetLength(0); r++)
        {
            for (int c = 0; c < _matrix.GetLength(1); c++)
            {
                sb.Append(_matrix[r, c]);
                if (c < _matrix.GetLength(1) - 1) sb.Append(", ");
            }
            if (r < _matrix.GetLength(0) - 1) sb.AppendLine();
        }
        return sb.ToString();
    }

    public void Reset() => Array.Clear(_matrix, 0, _matrix.Length);
}
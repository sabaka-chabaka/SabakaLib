namespace SabakaLib;

public class FloatMatrix(int rows, int columns) : Matrix<float>(rows, columns)
{
    public static FloatMatrix Add(FloatMatrix first, FloatMatrix second)
    {
        if (second.Rows != first.Rows || second.Columns != first.Columns) throw new InvalidOperationException();
        
        var matrix = new FloatMatrix(first.Rows, first.Columns);
        
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Columns; j++)
            {
                matrix[i,j] = first[i,j] + second[i,j];
            }
        }
        
        return matrix;
    }
}
using Xunit;

namespace SabakaLib.UnitTests;

public class MatrixTests
{
    [Fact]
    public void ToString_ReturnsCorrectString()
    {
        Matrix<int> m = new(2, 2)
        {
            [0, 0] = 1
        };
        
        Assert.Equal("1, 0\r\n0, 0", m.ToString());
    }
    
    [Fact]
    public void Reset_ResetsMatrix()
    {
        Matrix<int> m = new(2, 2)
        {
            [0, 0] = 1
        };
        
        m.Reset();
        
        Assert.Equal(0, m[0, 0]);
    }
}
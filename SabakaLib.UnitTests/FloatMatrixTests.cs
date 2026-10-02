using Xunit;

namespace SabakaLib.UnitTests;

public class FloatMatrixTests
{
    [Fact]
    public void FloatMatrix_Adds()
    {
        var a = new FloatMatrix(3, 3);

        a[0 ,0] = 1;
        a[1 ,0] = 2;
        a[2 ,0] = 3;
        a[0 ,1] = 4;
        a[1 ,1] = 5;
        a[2 ,1] = 6;
        a[0 ,2] = 7;
        a[1 ,2] = 8;
        a[2 ,2] = 9;
        
        var b = new FloatMatrix(3, 3);
        
        b[0 ,0] = 1;
        b[1 ,0] = 2;
        b[2 ,0] = 3;
        b[0 ,1] = 4;
        b[1 ,1] = 5;
        b[2 ,1] = 6;
        b[0 ,2] = 7;
        b[1 ,2] = 8;
        b[2 ,2] = 9;
        
        var c = new FloatMatrix(3, 3);
        c = FloatMatrix.Add(a, b);
        
        Assert.Equal(2, c[0, 0]);
        Assert.Equal(4, c[1, 0]);
        Assert.Equal(8, c[0, 1]);
    }
}
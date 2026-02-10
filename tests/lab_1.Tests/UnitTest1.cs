namespace lab_1.Tests;

[TestFixture]
public class MatrixTests
{
    [Test]
    public void Xor_ValidMatrices_ReturnsCorrectBitwiseResult()
    {
        // Arrange
        var a = new Matrix(new[,] { { 5 } });
        var b = new Matrix(new[,] { { 3 } });
        var expected = new Matrix(new[,] { { 6 } });

        // Act
        Matrix c = a.Xor(b);

        // Assert
        Assert.That(c, Is.EqualTo(expected));
    }

    [Test]
    public void GetAverage_SimpleMatrix_ReturnsCorrectColumnAverages()
    {
        // Arrange
        var matrix = new Matrix(new[,] {
                { 10, 20 },
                { 30, 40 }
            });
        double[] expected = { 20.0, 30.0 };

        // Act
        double[] result = matrix.GetAverage();

        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.01));
    }
}

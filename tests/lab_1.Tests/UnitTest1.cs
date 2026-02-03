using NUnit.Framework;
using lab_1;
using System;

namespace lab_1.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Xor_ValidMatrices_ReturnsCorrectBitwiseResult()
        {
            // Arrange
            int[,] a = { { 5 } }; // 0101
            int[,] b = { { 3 } }; // 0011
            int[,] expected = { { 6 } }; // 0110

            // Act
            int[,] result = MatrixOperations.Xor(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Xor_IncompatibleSizes_ThrowsArgumentException()
        {
            int[,] a = { { 1, 2 } };
            int[,] b = { { 1 } };

            Assert.Throws<ArgumentException>(() => MatrixOperations.Xor(a, b));
        }

        [Test]
        public void GetAverage_SimpleMatrix_ReturnsCorrectColumnAverages()
        {
            // Arrange
            int[,] matrix = {
                { 10, 20 },
                { 30, 40 }
            };
            double[] expected = { 20.0, 30.0 }; // (10+30)/2 = 20, (20+40)/2 = 30

            // Act
            double[] result = MatrixOperations.GetAverage(matrix);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.01));
        }

        [Test]
        public void Xor_NullInput_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => MatrixOperations.Xor(null, null));
        }
    }
}
using Calculators;
using Moq;
using Xunit;

namespace Test {
	public class SeriesMockTests {
		[Fact]
		public void Fibonacci_Should_ReturnNumber_OfSucession() {
			// Arrange
			int expected = 21;
			int indexSucesion = 8;
			
			var mock = new Mock<ICalculator>();

			mock.Setup(calc =>
							calc.Add(It.IsAny<int>(), It.IsAny<int>())
					)
			.Returns((int a, int b) => a + b);

			Series myTestSeries = new Series(mock.Object);

			// Act
			int result = myTestSeries.Fibonacci(indexSucesion);

			//Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Factorial_Should_ReturnFactorial_OfNumber() {
			// Arrange
			int excpeted = 720;
			int factorial = 6;

			var mock = new Mock<ICalculator>();

			mock.Setup(calc =>
							calc.Mul(It.IsAny<int>(), It.IsAny<int>())
					)
			.Returns((int a, int b) => a * b);

			Series myTestSeries = new Series(mock.Object);

			//Act
			int result = myTestSeries.Factorial(factorial);

			//Assert
			Assert.Equal(excpeted, result);
		}
	}
}
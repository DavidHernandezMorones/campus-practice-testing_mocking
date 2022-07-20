using Calculators;
using Xunit;

namespace Test {
	public class CalculatorTests {
		[Fact]
		public void Add_Should_ReturnSum_OfTwoNumbers() {
			// Arrange
			var calc = new Calculator();
			float a = 5;
			float b = 6;
			float expected = 11;

			// Act
			float result = calc.Add(a, b);

			// Assert
			Assert.Equal(expected, result);
		}

		[Fact]
		public void Sub_Should_ReturnSubstraction_OfTwoNumbers() {
			// Arrange
			var calc = new Calculator();
			float a = 5;
			float b = 6;
			float expected = -1;

			// Act
			float result = calc.Sub(a, b);

			// Assert
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(5, 3, 15)]
		[InlineData(75, 288, 21600)]
		[InlineData(265.9, 45.2, 12018.68)]
		[InlineData(100, 100, 10000)]
		[InlineData(2.3, 568, 1306.4)]
		public void Mul_Should_ReturnMultiplication_TwoNumbers(float a, float b, float expected) {
			// Arrange
			var calc = new Calculator();
			
			// Act
			float result = calc.Mul(a, b);
			
			// Assert
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(6, 3, 2)]
		[InlineData(25, 5, 5)]
		[InlineData(3, 2, 1.5)]
		[InlineData(100, 100, 1)]
		[InlineData(98, 4.9, 20)]
		public void Div_Should_ReturnDivision_OfTwoNumbers(float a, float b, float expected) {
			// Arrange
			var calc = new Calculator();
			
			// Act
			float result = calc.Div(a, b);
			
			// Assert
			Assert.Equal(expected, result);
		}
	}
}
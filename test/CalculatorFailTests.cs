using System;
using Calculators;
using Xunit;

namespace Test {
	public class CalculatorFailTests {
		[Fact]
		public void Div_Should_RaiseError_WhenDividedByZero() {
			// Arrange
			var calc = new Calculator();
			float a = 5;
			float b = 0;

			// Act
			// Assert
			Assert.Throws<DivideByZeroException>(() => calc.Div(a, b));
		}
	}
}
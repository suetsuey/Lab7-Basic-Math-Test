using System.Diagnostics;

namespace BasicMathTests
{
    public class BasicMathTest
    {
        [Test]
        public void TestAddingSumIs10()
        {
            double expectedAns = 10;
            double firstNum = 3;
            double secondNum = 7;

            BasicMath.BasicMath calculation = new BasicMath.BasicMath(firstNum, secondNum);

            double actualAns = calculation.GetAdd();

            Assert.AreEqual(expectedAns, actualAns);
        }

        [Test]
        public void TestSubstractDiffIs0()
        {
            double expectedAns = 0;
            double firstNum = 99;
            double secondNum = 99;

            BasicMath.BasicMath calculation = new BasicMath.BasicMath(firstNum, secondNum);

            double actualAns = calculation.GetSubstract();

            Assert.AreEqual(expectedAns, actualAns);
        }

        [Test]
        public void TestDivideQuotientIs3()
        {
            double expectedAns = 3;
            double firstNum = 33;
            double secondNum = 11;

            BasicMath.BasicMath calculation = new BasicMath.BasicMath(firstNum, secondNum);

            double actualAns = calculation.GetDivide();

            Assert.AreEqual(expectedAns, actualAns);
        }

        [Test]
        public void TestMultiplyProductIs45()
        {
            double expectedAns = 45;
            double firstNum = 9;
            double secondNum = 5;

            BasicMath.BasicMath calculation = new BasicMath.BasicMath(firstNum, secondNum);

            double actualAns = calculation.GetMultiply();

            Assert.AreEqual(expectedAns, actualAns);
        }
    }
}
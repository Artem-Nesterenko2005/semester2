namespace TestCalculator
{
    public class Tests
    {
        [Test]
        public void TestAddFirstNumber()
        {
            CalculatorOperations calculator = new();
            calculator.AddNumber('1');
            calculator.AddNumber('2');
            Assert.IsTrue(calculator.GetNumber1 == "12" && calculator.GetNumber2 == null);
        }

        [Test]
        public void TestAddOperation()
        {
            CalculatorOperations calculator = new();
            calculator.AddNumber('1');
            calculator.PerformOperation('*');
            Assert.IsTrue(calculator.GetNumber1 == "1" && calculator.GetNumber2 == null && calculator.GetOperation == '*');
        }

        [Test]
        public void TestIncorrectOperator()
        {
            CalculatorOperations calculator = new();
            Assert.Throws<IncorrectOperator>(() => calculator.PerformOperation('a'));
        }

        [Test]
        public void TestAddTwoNumbers()
        {
            CalculatorOperations calculator = new();
            calculator.AddNumber('1');
            calculator.PerformOperation('*');
            calculator.AddNumber('2');
            Assert.IsTrue(calculator.GetNumber1 == "1" && calculator.GetNumber2 == "2");
        }

        [Test]
        public void TestNumberOperation()
        {
            CalculatorOperations calculator = new();
            calculator.AddNumber('1');
            calculator.AddNumber('2');
            calculator.PerformOperation('/');
            calculator.AddNumber('3');
            calculator.PerformOperation('+');
            Assert.IsTrue(calculator.GetNumber1 == "4" && calculator.GetOperation == '+');
        }

        [Test]
        public void TestFreeData()
        {
            CalculatorOperations calculator = new();
            calculator.AddNumber('1');
            calculator.AddNumber('2');
            calculator.PerformOperation('+');
            calculator.AddNumber('3');
            calculator.AddNumber('4');
            calculator.FreeData();
            Assert.IsTrue(calculator.GetNumber1 == null && calculator.GetNumber2 == null && calculator.GetOperation == '\0');
        }
    }
}

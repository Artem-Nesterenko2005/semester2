/// <summary>
/// class for performing arithmetic operations on numbers
/// </summary>
public class CalculatorOperations
{
    private string? number1;

    private string? number2;

    private char operation;

    /// <summary>
    /// returns a current operation
    /// </summary>
    public char GetOperation => operation;

    /// <summary>
    /// returns a string that identifies the first number
    /// </summary>
    public string? GetNumber1 => number1;

    /// <summary>
    /// returns a string that identifies the second number
    /// </summary>
    public string? GetNumber2 => number2;

    /// <summary>
    /// changes the operator if there is no second number, or performs the operation in accordance with the operation
    /// </summary>
    /// <param name="operand">operand received at the input</param>
    public void PerformOperation(char operand)
    {
        if (operand != '+' && operand != '-' && operand != '*' && operand != '/' && operand != '=')
        {
            throw new IncorrectOperator("symbol is not an operator");
        }

        if (number1 == null)
        {
            return;
        }

        if (operand != '\0' && number2 == null && operand != '=')
        {
            this.operation = operand;
            return;
        }

        if (operation != '\0' && number2 != null)
        {
            switch (operation)
            {
                case '*':
                    number1 = (int.Parse(number1!) * int.Parse(number2!)).ToString();
                    break;

                case '-':
                    number1 = (int.Parse(number1!) - int.Parse(number2!)).ToString();
                    break;

                case '+':
                    number1 = (int.Parse(number1!) + int.Parse(number2!)).ToString();
                    break;

                case '/':
                    number1 = (int.Parse(number1!) / int.Parse(number2!)).ToString();
                    break;
            }
            number2 = null;
            this.operation = operand != '=' ? operand : this.operation;
            return;
        }
        operation = operand == '=' ? operation : operand;
    }

    /// <summary>
    /// character by character adds numbers to first or second number
    /// </summary>
    /// <param name="number">number to add to first or second number</param>
    public void AddNumber(char number)
    {
        if (operation == '\0')
        {
            number1 += number;
            return;
        }
        number2 += number;
    }

    /// <summary>
    /// clears data from numbers and operator
    /// </summary>
    public void FreeData()
    {
        number1 = null;
        number2 = null;
        operation = '\0';
    }
}

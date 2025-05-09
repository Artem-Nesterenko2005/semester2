/// <summary>
/// exception thrown when trying to add an invalid character instead of an operation
/// </summary>
public class IncorrectOperator : SystemException
{
    /// <summary>
    /// constructor for exception
    /// </summary>
    /// <param name="text">text for exception</param>
    public IncorrectOperator(string text) : base(text)
    {
    }
}

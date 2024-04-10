public class Program
{
    static void Main()
    {
        var functions = new ListFunction();
        var list = new List<int> { 2, 4, 5 };
        var resultMap = functions.Map(list, x => x + 5);
        var resultFilter = functions.Filter(list, x => x > 2);
        var resultFold = functions.Fold(list, 3, (acc, elem) => acc * elem);
    }
}

/// <summary>
/// a class with functions Map, Filter, Fold that interact with lists and their elements
/// </summary>
public class ListFunction()
{
    /// <summary>
    /// a method that changes all elements of a list according to the rule specified by the function
    /// </summary>
    /// <param name="list">initial list with elements</param>
    /// <param name="function">function that transforms all elements of a list</param>
    /// <returns>list of elements converted by the function</returns>
    public List<int> Map(List<int> list, Func<int, int> function)
    {
        var result = new List<int>();
        foreach(var i in list)
        {
            result.Add(function(i));
        }
        return result;
    }

    /// <summary>
    /// a method that checks the elements of a list to see if they match the conditions of a function
    /// </summary>
    /// <param name="list">initial list with elements</param>
    /// <param name="function">function with a given condition</param>
    /// <returns>a list with elements that satisfy the conditions of the function</returns>
    public List<int> Filter(List<int> list, Func <int, bool> function)
    {
        var result = new List<int>();
        foreach (var i in list)
        {
            if (function(i))
            {
                result.Add(i);
            }
        }
        return result;
    }

    /// <summary>
    /// method that returns the product of all elements of the list and startNumber
    /// </summary>
    /// <param name="list">initial list with elements</param>
    /// <param name="startNumber">initial value</param>
    /// <param name="function">a function that performs an operation on the elements of a list</param>
    /// <returns>the result of operations on all elements of the list and the initial value</returns>
    public int Fold(List<int> list, int startNumber, Func<int, int, int> function)
    {
        var result = startNumber;
        foreach(var i in list)
        {
            result = function(result, i);
        }
        return result;
    }
}

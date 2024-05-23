//MIT License
//Copyright (c) 2024 Artem-Nesterenko2005
//All rights reserved

/// <summary>
/// class for vector operations such as subtraction, addition, scalar multiplication
/// </summary>
public class VeсtorOperations
{
    /// <summary>
    /// checks if a vector is null
    /// </summary>
    /// <param name="vector">a vector that is tested for a null vector</param>
    /// <returns>whether the vector is null</returns>
    public bool CheckNullVector(Dictionary<int, int> vector)
    {
        if (vector == null)
        {
            return true;
        }

        foreach (var i in vector)
        {
            if (i.Value != 0)
            {
                return false;
            }
        }
        return true; 
    }

    /// <summary>
    /// scalar multiplication of vectors by their coordinates
    /// </summary>
    /// <param name="firstVector">first factor vector</param>
    /// <param name="secondVector">second factor vector</param>
    /// <returns>vector, the result of multiplying two vectors</returns>
    public int Multiplicate(Dictionary <int, int> firstVector, Dictionary<int, int> secondVector)
    {
        var multiVector = new Dictionary<int, int>();
        Dictionary<int, int> auxiliaryVector = new Dictionary<int, int>(secondVector);
        foreach (var i in firstVector)
        {
            if (auxiliaryVector.ContainsKey(i.Key))
            {
                multiVector.Add(i.Key, i.Value * auxiliaryVector[i.Key]);
                auxiliaryVector.Remove(auxiliaryVector.Keys.First());
                continue;
            }
        }

        int result = 0;
        foreach(var i in multiVector)
        {
            result += i.Value;
        }
        return result;
    }

    /// <summary>
    /// addition of vectors by their coordinates
    /// </summary>
    /// <param name="firstVector">the first term is a vector</param>
    /// <param name="secondVector">the second term is a vector</param>
    /// <returns>vector, the result of addition two vectors</returns>
    public Dictionary<int, int> Addition(Dictionary<int, int> firstVector, Dictionary<int, int> secondVector)
    {
        var result = new Dictionary<int, int>();
        Dictionary<int, int> auxiliaryVector = new Dictionary<int, int>(secondVector);
        foreach (var i in firstVector)
        {
            while (auxiliaryVector.Count != 0 && !firstVector.ContainsKey(auxiliaryVector.Keys.First()) && i.Key > auxiliaryVector.Keys.First())
            {
                result.Add(auxiliaryVector.Keys.First(), auxiliaryVector.Values.First());
                auxiliaryVector.Remove(auxiliaryVector.Keys.First());
            }

            if (auxiliaryVector.ContainsKey(i.Key))
            {
                result.Add(i.Key, i.Value + auxiliaryVector[i.Key]);
                auxiliaryVector.Remove(auxiliaryVector.Keys.First());
                continue;
            }

            result.Add(i.Key, i.Value);
        }
        while (auxiliaryVector.Count != 0)
        {
            result.Add(auxiliaryVector.Keys.First(), auxiliaryVector.Values.First());
            auxiliaryVector.Remove(auxiliaryVector.Keys.First());
        }
        return result;
    }

    /// <summary>
    /// subtracting vectors by their coordinates
    /// </summary>
    /// <param name="firstVector">subtractive vector</param>
    /// <param name="secondVector">subtractor vector</param>
    /// <returns>vector, the result of subtracting one vector from another</returns>
    public Dictionary<int, int> Subtraction(Dictionary<int, int> firstVector, Dictionary<int, int> secondVector)
    {
        var result = new Dictionary<int, int>();
        Dictionary<int, int> auxiliaryVector = new Dictionary<int, int>(secondVector);
        foreach (var i in firstVector)
        {
            while (auxiliaryVector.Count != 0 && !firstVector.ContainsKey(auxiliaryVector.Keys.First()) && i.Key > auxiliaryVector.Keys.First())
            {
                result.Add(auxiliaryVector.Keys.First(), -auxiliaryVector.Values.First());
                auxiliaryVector.Remove(auxiliaryVector.Keys.First());
            }

            if (auxiliaryVector.ContainsKey(i.Key))
            {
                if (i.Value - auxiliaryVector[i.Key] != 0)
                {
                    result.Add(i.Key, i.Value - auxiliaryVector[i.Key]);
                }
                auxiliaryVector.Remove(auxiliaryVector.Keys.First());
                continue;
            }

            result.Add(i.Key, i.Value);
        }
        while (auxiliaryVector.Count != 0)
        {
            result.Add(auxiliaryVector.Keys.First(), -auxiliaryVector.Values.First());
            auxiliaryVector.Remove(auxiliaryVector.Keys.First());
        }
        return result;
    }  
}

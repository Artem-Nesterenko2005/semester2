//MIT License
//Copyright (c) 2024 Artem-Nesterenko2005
//All rights reserved

/// <summary>
/// exception thrown when trying to remove an element from an empty queue
/// </summary>
public class EmptyPriorityQueueExceprion : SystemException
{
    public EmptyPriorityQueueExceprion(string text) : base(text)
    {
    }
}

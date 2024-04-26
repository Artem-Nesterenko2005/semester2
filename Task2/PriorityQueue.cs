//MIT License
//Copyright (c) 2024 Artem-Nesterenko2005
//All rights reserved

/// <summary>
/// class for a priority queue, working on the principle first-in-first-out, 
/// containing methods Enqueue for adding and Dequeue for removing elements and a property indicating whether the queue is empty
/// </summary>
/// <typeparam name="T">type of data</typeparam>
public class PriorityQueue<T>
{
    private QueueElement<T> ?head;

    /// <summary>
    /// property, indicating whether it is empty
    /// </summary>
    public bool Empty => head == null;

    /// <summary>
    /// method for adding data to a queue
    /// </summary>
    /// <param name="data">data added to queue</param>
    /// <param name="priority">priority of added data</param>
    public void Enqueue(T data, int priority)
    {
        if (Empty)
        {
            head = new QueueElement<T>();
            head.data = data;
            head.priority = priority;
            return;
        }

        if (head.priority < priority)
        {
            QueueElement<T> node = new();
            node.data = data;
            node.priority = priority;
            node.next = head;
            head = node;
            return;
        }

        var currentNode = head;
        while (currentNode.next != null && currentNode.next.priority > priority)
        {
            currentNode = currentNode.next;
        }

        if (currentNode.next != null && currentNode.priority == priority)
        {
            while (currentNode.next != null && currentNode.priority == priority)
            {
                currentNode = currentNode.next;
            }
        }

        QueueElement<T> newNode = new();
        newNode.data = data;
        newNode.priority = priority;
        newNode.next = currentNode.next;
        currentNode.next = newNode;
    }

    /// <summary>
    /// method that returns and removes the top value from the queue
    /// </summary>
    /// <returns>data from top of queue</returns>
    /// <exception cref="EmptyPriorityQueueExceprion">exception thrown when trying to remove an element from an empty queue</exception>
    public T Dequeue()
    {
        if (Empty)
        {
            throw new EmptyPriorityQueueExceprion("deletion is not possible because the queue is empty");
        }
        T data = head.data;
        head = head.next;
        return data;
    }

    private class QueueElement<U>
    {
        /// <summary>
        /// data from node
        /// </summary>
        public U ?data;

        /// <summary>
        /// priority from node
        /// </summary>
        public int priority;

        /// <summary>
        /// next node of queue
        /// </summary>
        public QueueElement<U> ?next;
    }
}

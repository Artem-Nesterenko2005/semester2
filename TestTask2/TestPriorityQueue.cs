//MIT License
//Copyright (c) 2024 Artem-Nesterenko2005
//All rights reserved

namespace TestTask2
{
    public class Tests
    {
        [Test]
        public void TestEnqueueDequeueData()
        {
            PriorityQueue<int> queue = new();
            queue.Enqueue(1, 4);
            queue.Enqueue(2, 2);
            queue.Enqueue(3, 3);
            queue.Enqueue(4, 1);
            Assert.IsTrue(queue.Dequeue() == 1 && queue.Dequeue() == 3 && queue.Dequeue() == 2 && queue.Dequeue() == 4);
        }

        [Test]
        public void TestEmptyQueue()
        {
            PriorityQueue<int> queue = new();
            Assert.IsTrue(queue.Empty);
        }

        [Test]
        public void TestCheckNonEmptyForEmpty()
        {
            PriorityQueue<string> queue = new();
            queue.Enqueue("123", 2);
            Assert.IsTrue(!queue.Empty);
        }

        [Test]
        public void TestDequeueEmptyQueue()
        {
            PriorityQueue<string> queue = new();
            Assert.Throws<EmptyPriorityQueueExceprion>(() => queue.Dequeue());
        }

        [Test]
        public void TestEnqueueSamePriority()
        {
            PriorityQueue<int> queue = new();
            queue.Enqueue(5, 1);
            queue.Enqueue(2, 1);
            queue.Enqueue(3, 1);
            queue.Enqueue(4, 1);
            Assert.IsTrue(queue.Dequeue() == 5 && queue.Dequeue() == 2 && queue.Dequeue() == 3 && queue.Dequeue() == 4);
        }
    }
}

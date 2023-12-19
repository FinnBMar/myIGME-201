using System;
using System.Collections.Generic;

class MyQueue // Finn Marable IGME 102 Final Question 2
{
    private List<int> queueList;

    public MyQueue()
    {
        queueList = new List<int>();
    }

    public void Enqueue(int n)
    {
        queueList.Add(n);
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The queue is empty");
        }

        int dequeuedValue = queueList[0];
        queueList.RemoveAt(0);
        return dequeuedValue;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The queue is empty");
        }

        return queueList[0];
    }

    public bool IsEmpty()
    {
        return queueList.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        // Example usage
        MyQueue myQueue = new MyQueue();

        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);

        Console.WriteLine("Peek: " + myQueue.Peek());

        Console.WriteLine("Dequeue: " + myQueue.Dequeue());
        Console.WriteLine("Dequeue: " + myQueue.Dequeue());

        myQueue.Enqueue(4);

        Console.WriteLine("Peek: " + myQueue.Peek());
    }
}

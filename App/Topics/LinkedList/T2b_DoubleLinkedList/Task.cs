namespace App.Topics.LinkedList.T2b_DoubleLinkedList;

public class DoubleLinkedList<T>
{
    public T Value { get; }
    public DoubleLinkedList<T>? Prev { get; private set; }
    public DoubleLinkedList<T>? Next { get; private set; }

    public DoubleLinkedList(T value)
    {
        Value = value;
    }

    public int Count
    {
        get
        {
            var head = this;
            while (head.Prev != null)
            {
                head = head.Prev;
            }

            int count = 0;
            var current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }
    }

    public void AddBefore(T value)
    {
        var newNode = new DoubleLinkedList<T>(value);
        newNode.Prev = Prev;
        newNode.Next = this;

        if (Prev != null)
        {
            Prev.Next = newNode;
        }
        Prev = newNode;
    }

    public void AddAfter(T value)
    {
        var newNode = new DoubleLinkedList<T>(value);
        newNode.Prev = this;
        newNode.Next = Next;

        if (Next != null)
        {
            Next.Prev = newNode;
        }
        Next = newNode;
    }

    public void AddFirst(T value)
    {
        var head = this;
        while (head.Prev != null)
        {
            head = head.Prev;
        }
        head.AddBefore(value);
    }

    public void AddLast(T value)
    {
        var tail = this;
        while (tail.Next != null)
        {
            tail = tail.Next;
        }
        tail.AddAfter(value);
    }

    public T[] ToArray()
    {
        var head = this;
        while (head.Prev != null)
        {
            head = head.Prev;
        }

        var result = new T[Count];
        var current = head;
        int index = 0;

        while (current != null)
        {
            result[index++] = current.Value;
            current = current.Next;
        }

        return result;
    }
}

using System;

///<summary>My implementation of Queue type </summary>
class Queue<T>
{
    public class Node
    {
        public T value;
        public Node next = null;

        ///<summary> sets node value</summary>
        public Node(T value, Node next = null)
        {
            this.value = value;
            this.next = next;
        }
    }
    Node head = null;
    Node tail = null;

    int count = 0;

    /// <summary>checks type of T</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    ///<summary> enqueues a new node with value </summary>
    public void Enqueue(T value)
    {
        count += 1;

        var node = new Node(value);

        if (head == null)
            head = node;

        if (tail != null)
            tail.next = node;

        tail = node;
    }

    ///<summary>counts # of nodes</summary>
    public int Count()
    {
        return count;
    }
}

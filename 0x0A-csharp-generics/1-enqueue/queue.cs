using System;

///<summary></summary>
    class Queue<T>
    {
        public Type CheckType()
        {
            return typeof(T);
        }

        public class Node
        {
            public T value = null;
            public Node next = null;

            public Node(T value)
            {
                this.value = value;
            }
        }

        public Node head;
        public Node tail;
        public int count;

        public void Enqueue()
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = node;
            }
            if (tail != null)
            {
                tail.next = node;
            }
            tail = node;
            count ++;
            
        }

        public int Count()
        {
            return count;
        }
    }

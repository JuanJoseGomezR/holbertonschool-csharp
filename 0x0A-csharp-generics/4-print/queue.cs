using System;


/// <summary>within Queue T, create a public class called Node.</summary>
class Queue<T>
{
	public class Node
	{
		public T value;
		/// <summary>Pointer to the next node in our queue.</summary>
		public Node next = null;
		/// <summary>Creates a new node with given element as value for a new Node.</summary>
		public Node(T value) {
			this.value = value;
		}
	}
	/// <summary>Pointer to head of queue.</summary>
	public Node head;
	/// <summary>Pointer to tail of queue.</summary>
	public Node tail;


	/// <summary>Number of nodes in queue.</summary>
	public int count = 0;

	/// <summary>Returns type of T parameter.</summary>
	public Type CheckType() {
		return typeof(T);
	}

	/// <summary>Adds new element to the tail of the queue.</summary>
	public void Enqueue(T value) {
		Node node;

		node = new Node(value);
		if (this.head == null)
			this.head = node;
		if (this.tail != null)
			this.tail.next = node;
		this.tail = node;
		this.count++;
	}

	public T Dequeue()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			T value = head.value;
			head = head.next;
			count--;
			return value;
		}
	}
	/// <summary>Returns the number of nodes in the queue.</summary>
	public int Count() {
		return this.count;
	}

	///<summary> returns value of the first node </summary>
	public T Peek()
	{
		if  (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			return head.value;
		}
	}

	///<summary> prints queue starting from the head </summary>
	public void Print()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
		}
		else
		{
			while (head != null)
			{
				Console.WriteLine(head.value);
				head = head.next;
			}
		}
	}
}

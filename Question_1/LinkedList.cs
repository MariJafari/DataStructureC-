using System;
using System.Xml.Linq;

namespace Question_1
{
	public class LinkedList<T>where T: IComparable<T>
	{
		public Node<T>? head;

		public LinkedList()
		{
		}

		public void Add(T data)
		{
			Node<T> newNode = new Node<T>(data);
			if (head == null)
			{
				head = newNode; 
			}
			else
			{
				Node<T> current = head;
				while (current.Next != null)
				{
					current = current.Next; 
				}
				current.Next = newNode;
			}
		}

		public void Display()
		{
			Node<T> current = head;
			while(current != null)
			{
				Console.WriteLine($"{current.Data} ->");
				current = current.Next; 
			}
			Console.WriteLine("Null");
		
        }
        public void Sort()
        {
            if (head == null)
            {
                // The list is empty or has only one element; no need to sort.
                return;
            }

            bool swapped;
            do
            {
                Node<T> current = head;
                
                swapped = false;

                while (current.Next != null)
                {
                    if (current.Data.CompareTo(current.Next.Data) > 0)
                    {
                        // Swap the current and next nodes' data.
                        T temp = current.Data;
                        current.Data = current.Next.Data;
                        current.Next.Data = temp;
                        swapped = true;
                    }

                    
                    current = current.Next;
                }
            }
            while (swapped);
        }
    }
}


using System;
using System.Collections.Generic;


namespace Question_1
{
    internal class Program
    {
        public static void Main()
        {
            /*Arrays*/
            String[] nameArray = new string[5];
            nameArray[0] = "Marjan Jafari";
            nameArray[1] = "Jim kola";
            nameArray[2] = "Maxi Holk";
            nameArray[3] = "Sara Kari";
            nameArray[4] = "Shayan Khalaji";
            //nameArray[5] = "asdasdas";  --adding one more will exceed the size of the array and will throw IndexOutOfRange Exception 
            //array are fixed in size 
            Console.WriteLine("Array Example: (Sorted)");
            Array.Sort(nameArray); //sorts array 
            foreach (String name in nameArray)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"First Array: {nameArray.First()}"); //can display first array by using the First Function of Array
            Console.WriteLine("=======================");

            /*LinkedList*/
            LinkedList<string> cityList = new LinkedList<string>();

            // Adding city names to the linked list
            cityList.Add("Montreal");
            cityList.Add("London");
            cityList.Add("Hamilton");
            cityList.Add("Barrie");
            //The size of linkedlist is dynamic and can add data in the future. 
            cityList.Add("Toronto");
            cityList.Sort(); //I created a sort method to sort data in the linkedlist
            // Displaying the list of city names
            Console.WriteLine("LinkedList Example: (Sorted) ");
            cityList.Display();
            Console.WriteLine($"First LinkedList: {cityList.head.Data}"); //display the head as the first data in the list 

            Console.WriteLine("=======================");
            Console.WriteLine("Stack Example:");
            /*STACK EXAMPLE LIFO */
            Stack<int> stack = new Stack<int>();
            //To add elements, need to use Push func
            stack.Push(5);
            stack.Push(2);
            stack.Push(3);
            stack.Push(1);
            Console.WriteLine($"Number of Stack: {stack.Count()}");
            Console.WriteLine($"Last In data: {stack.Peek()}");
            stack.Pop();
            Console.WriteLine($"After Pop Next Data: {stack.Peek()}");

            /*QUEUE EXAMPLE FIFO */
            Console.WriteLine("=======================");
            Console.WriteLine("Queue Example:");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("Z");
            queue.Enqueue("B");
            queue.Enqueue("C");
            Console.WriteLine($"Number of Queues: {queue.Count}");
            Console.WriteLine($"FIFO: {queue.Dequeue()}");
            Console.WriteLine($"Next Queue: {queue.Dequeue()}");

            /*TYPE CONSTRAINTS EXAMPLE*/
            Console.WriteLine("=======================");
            Console.WriteLine("Type Constraints Example:");
            TypeConstraint example = new TypeConstraint();

            // Compare integers in a list
            List<int> intList = new List<int> { 5, 12, 8, 3, 9, 1 };
            int maxInt = example.FindMax(intList);
            Console.WriteLine($"Max value for INT: {maxInt}");

            // Compare doubles in a list
            List<double> doubleList = new List<double> { 2.5, 1.0, 3.7, 2.1, 4.9 };
            double maxDouble = example.FindMax(doubleList);
            Console.WriteLine($"Max value for DOUBLE: {maxDouble}");

            // Compare strings in a list
            List<string> stringList = new List<string> {"a", "aaaa", "aaa", "aaaaaaaa"};
            string maxString = example.FindMax(stringList);
            Console.WriteLine($"Max value for STRING {maxString}");
        }


    }

    public class TypeConstraint
    {
        public T FindMax<T>(List<T> values) where T : IComparable<T>
        {
            if (values.Count == 0)
            {
                throw new ArgumentException("The list cannot be empty.");
            }

            T max = values[0];

            foreach (T value in values)
            {
                if (value.CompareTo(max) > 0)
                {
                    max = value;
                }
            }

            return max;
        }
    }
}




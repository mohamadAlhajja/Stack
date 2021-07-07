using System;
using System.Collections.Generic;
using System.Linq;

namespace StackTask
{
    public class main
    {
        static void Main(string[] args)
        {
            StackTask<int> stack = new StackTask<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Pop();
            stack.Pop();
            stack.Print();
            stack.Peek();
            stack.Clear();



        }
    }
    public interface IStackTask<T>
    {
        void Push(T value);
        T Pop();
        void Print();
        T Peek();
        void Clear();
    }
    public class StackTask<T> : IStackTask<T>
    {
        private List<T> StackList = new List<T>();
        public void Push(T element)
        {
            StackList.Add(element);
            Console.WriteLine($"{element} pushed");
        }
        public T Pop()
        {
            try
            {
                T last = StackList[StackList.Count - 1];
                StackList.RemoveAt(StackList.Count - 1);
                Console.WriteLine($"{last} poped");
                return last;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        public void Print()
        {
            Console.WriteLine($"Printing stack elements:");
            foreach (var value in Enumerable.Reverse(StackList))
            {
                Console.Write($"{value}, ");
            }
            Console.WriteLine();
        }
        public T Peek()
        {
            try
            {
                T last = StackList[StackList.Count - 1];
                Console.WriteLine($"{last} on top");
                return last;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }


        }
        public void Clear()
        {
            Console.WriteLine($"Clearing the stack..");
            StackList.Clear();
        }

    }
}

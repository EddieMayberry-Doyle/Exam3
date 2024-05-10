using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word or phrase and the program will check if it is a palendrome");
            string input = Console.ReadLine();
            string h = "";
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    h += c;
                }
            }
            string final = h.ToLower();
            if (IsPalindrome(final))
            {
                Console.WriteLine("This is a palendrome");
            }
            else
            {
                Console.WriteLine("This is not a palendrome");
            }
        }

        static bool IsPalindrome(string test)
        {

            Stack<char> myStack = new Stack<char>();
            Queue<char> myQueue = new Queue<char>();
            foreach (char c in test)
            {
                myStack.Push(c);
                myQueue.Enqueue(c);
            }
            for (int i = 0; i < test.Length; i++)
            {
                if (myStack.Peek() == myQueue.Peek())
                {
                    myStack.Pop();
                    myQueue.Dequeue();
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
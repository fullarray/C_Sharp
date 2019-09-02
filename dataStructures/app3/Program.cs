using System;
using System.Collections.Generic;

namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
			
			numbers.AddLast(456);
			numbers.AddLast(146);
			numbers.AddLast(41);
			numbers.AddLast(6);
			numbers.AddLast(1564);
			numbers.AddLast(12);

			LinkedListNode<int> node = numbers.Find(41);
			numbers.AddBefore(node, 19);
			
			foreach(int num in numbers){
				Console.WriteLine(num);
			}
        }
    }
}

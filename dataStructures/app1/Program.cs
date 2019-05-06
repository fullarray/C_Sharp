using System;
using System.Collections;

namespace app1
{
    class Program
    {
	class Empty{}
		
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
			numbers.Add(33);
			numbers.Add(56);
			numbers.Add(92);
			numbers.Add(45);
			numbers.Add(10);
			numbers.Add(new Empty{});
			foreach(object number in numbers){
				Console.WriteLine(number);
			}
        }
    }
}

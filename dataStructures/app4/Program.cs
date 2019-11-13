using System;
using System.Collections;

namespace app4
{
    class Program
    {
		//This method simply prints all values stored in lists.
		public static void printValues(IEnumerable langs){
			int i = 1;
			foreach(Object obj in langs){
				Console.WriteLine("{1} {0}", obj, i++);
			}
			Console.WriteLine();
		}
        static void Main(string[] args)
        {
			ArrayList programmingLang = new ArrayList();
			programmingLang.Add("VB");
			programmingLang.Add("C++");
			programmingLang.Add("C#");
			programmingLang.Add("PHP");
			programmingLang.Add("J2EE");
			
            Console.WriteLine("Starting values of ArrayList: ");
			printValues(programmingLang);
			
			programmingLang.Reverse();
			
			Console.WriteLine("ArrayList reversed: ");
			printValues(programmingLang);
        }
    }
}

using System;

namespace insertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write example run usin the functions below.
        }
		
		static void IntArrayInsertionSortImpl(int[] data)
		{
			int i, j;
			int N = data.Length;
			
			for(j = 1; j < N; j++)
			{
				for(i = j; i > 0 && data[i] < data[i - 1]; i--)
				{
					exchange(data, i, i - 1);
				}
			}
		}
		
		static void exchange (int[] data, int m, int n){
         
			int temporary;

			temporary = data [m];
			data [m] = data [n];
			data [n] = temporary;
		}
    }
}

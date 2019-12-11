using System;
// dotnet new console -o bubbleSort
// cd bubbleSorts
// dotnet run
namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort Implementation.\n");
            int[] data = {1,2,4,5,6,7,8};
            intArrayBubbleSort(data);
        }

        static void intArrayBubbleSort(int[] data){
            int i, j;
            int N = data.Length;

            for(j=N-1; j>0; j--){
                for(i=0; i<j; i++){
                    if(data[i] > data[i + 1]){
                        exchange(data, i, i+1);
                    }
                }
            }
        }

        static void exchange (int[] data, int m, int n)
        {
            int temporary;

            temporary = data [m];
            data [m] = data [n];
            data [n] = temporary;
            
        }
    }
}

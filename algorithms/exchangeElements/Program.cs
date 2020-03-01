using System;
//create command: dotnet new console exchangeElements
//run command: dotnet run

namespace exchangeElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Exchange values");
            int[] arr = {1,2,3,4,5, 6, 7, 9};

            exchange(arr, 7, 4);
        }

        //Exchanging values. 
        static void exchange(int[] data, int m, int n){
            int temporary;

            temporary = data [m];
            data[m] = data[n];
            data[n] = temporary;
            Console.WriteLine(temporary +", "+ data[m]);
        }
    }
}

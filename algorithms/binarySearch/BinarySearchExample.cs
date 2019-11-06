using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearch
{
    class BinarySearchExample
    {
        static void Main(string[] args)
        {
            int searchInt; // Search key
            int position;  // Location of search
            BinaryArray searchArray = new BinaryArray(15);
            Console.WriteLine(searchArray);
            // Prompt and input first int from user
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while(searchInt != -1)
            {
                // Use binary search to try to find integer
                position = searchArray.BinarySearch(searchInt);

                // Return value of -1 indicates integer was not found
                if(position == -1)
                {
                    Console.WriteLine("The integer {0} was not found. \n", searchInt);

                }
                else
                {
                    Console.WriteLine("The integer {0} was found in position {1}. \n", searchInt);

                }

                // Prompt and input next int from user
                Console.WriteLine("Please enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace BinarySearch
{
    class BinaryArray
    {
        private int[] data;
        private static Random generator = new Random();

        public BinaryArray(int size)
        {
            data = new int[size];

            for(int i=0; i<size; i++)
            {
                data[i] = generator.Next(10, 100);
            }
            Array.Sort(data);
        }
        // Perform a binary search on array
        public int BinarySearch(int searchElement)
        {
            int low = 0;
            int high = data.Length-1;
            int middle = (low + high + 1) / 2;
            int location = -1;

            do
            {
                for(int i =0; i < middle; i++)
                {
                    Console.Write("  ");
                }

                Console.WriteLine(" * ");

                // if element is found at middle
                if(searchElement == data[middle])
                {
                    location = middle; //Location is current middle
                }else if(searchElement < data[middle])
                {
                    high = middle - 1; // Eleminate lower half
                }
                else // Middle element is too low
                {
                    low = middle + 1; // Eleminate lower half
                }

                middle = (low + high + 1) / 2; // Recalculate the middle

            }while((low <= high) && (location == -1));

            return location;
        }


        public string RemainingElements(int low, int high)
        {
            string temporary = string.Empty;

            for(int i=0; i<low; i++)
            {
                temporary += "   ";
            }

            for(int i=low; i<=high;i++)
            {
                temporary+=data[i] + " ";
            }

            temporary += "\n";
            return temporary;
        }

        // Method to output values in array
        public override string ToString()
        {
            return RemainingElements(0, data.Length -1);
        }
    }

}

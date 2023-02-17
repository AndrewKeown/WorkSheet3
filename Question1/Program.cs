using System.Globalization;

namespace Question1
{
    /*
     * Name : Andrew Keown
     * Date : 15/02/2023
     * Desc : Create test for each of the above methods.
     * Create a set of test arrays and test each of your methods.
     * What could "go wrong" with each method. 
     * Consider, empty arrays,arrays with only one element,arrays with negative numbers.
     * (1) The largest value in the array.
     * (2) The smallest value in the array.
     * (3) True if the array is sorted in ascending order otherwise false.
     * (4) The average of every third element in the array,starting with the first element.
     * (5) The standard deviation of all the values stored in the array.
     */
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] testArray = { 7, 3, 6, 2, 9 };
            
            

            

            
            }
        }

        static int GetMax(int[] numbers)
    {
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {

                largest = number;
            }


        }
        return largest;


    }
    
    }















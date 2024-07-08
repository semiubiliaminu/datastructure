using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(centeredElement(numbers));
        }


        /**
            An array with an odd number of elements is said to be centered if all elements (except the middle one) are strictly greater than the value of the middle element. Note that only arrays with an odd number of elements have a middle element. Write a function that accepts an integer array and returns 1 if it is a centered array, otherwise it returns 0.
        */
       static int centeredElement(int[] number){
            //check the lenght of array
            int size = number.Length;

            int result = 0;

            int count_middle_element = 0;

            if (size == 1)
            { // only 1 element
                return 1;
            }
          
            if (size > 1) // array element more than 1
            {
                Console.WriteLine("We got here "+ size);


                if (size % 2 == 0)
                { // number of elements in the aarray is even
                    Console.WriteLine("We got second if  " + size);
                    return 0;

                }
                else
                {
                    int middle_element = size % 2; // get the middle element
                    for (int i = 0; i < size; i++)
                    {
                        if (middle_element == number[i])
                        { // middle element equal to any of the element break out of the loop and return 0

                            count_middle_element++;
                            if (count_middle_element > 1)
                                return 0;
                        }
                        else
                        {
                            if (middle_element < number[i])
                            {
                                result++;
                            }
                            else
                            {
                                return 0;
                            }
                        }
                    }
                }
            }
            else
            {
                return 0;
            }

            if (result == size) //size of element that are less than the middle number is equal to size of the array
                Console.WriteLine("We got last if   " + result);
                return 1;
            
            Console.WriteLine("We got last if   " + result);
            return 1;
        }
    }
}

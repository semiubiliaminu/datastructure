﻿using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] input = {1, 1, 1, 5, 5, 5, 5, 8, 8, 8};

            int n = 4;

            Console.WriteLine(countBinaryOnes(n));

            

        }

        static int countBinaryOnes(int n) {
            // int count_one = 0;
            // int n = 8;
            // int reminder = n % 2;
            // int divisible = n / 2;
            // while (n / 2) {
            //     int k = n / 2;
            //     if (k * 2 != n) {
            //         // Console.WriteLine("Got here");
            //         count_one++;
            //     }
            //     n = k;

            // }

            int divisor = n;
            // int reminder = 0;
            int countOnes = 0;

            if (divisor == 0 )
                countOnes++;

            // Console.WriteLine("Divisor value  " + divisor);
            
            while(divisor >1 ){
                
                // if (divisor % 2 == 1) 
                // countOnes++;
                Console.WriteLine("Divisor value  " + divisor);
                int c = divisor / 2;
                if (divisor%2 == 1) countOnes++;
                divisor = divisor - c;
                // Console.WriteLine("Divisor value  " + divisor);
                // divisor = reminder;
            }

            return countOnes;

        }


        // int isStepped(int[ ] a){
        //     int size = a.Length;
        //     string distinct = "";
        //     int distinct_split = distinct.split(",");
        //     int count_distinct = distinct_split.Length;
        //     int count_num = 0;
            
        //     for(int i=0; i<size; i++){
        //         if(a[i] == a[i+i]){
        //             distinct = Convert.toString(a[i]);//a[i].toString() + ",";
        //         }

        //     }

        //     for(int k; k<count_distinct; k++){
                
        //         if(distinct_split[0] > distinct_split[1]){
        //             return distinct;
        //         }

        //     }
        //     return distinct;
            
        // }


        /**
            An array with an odd number of elements is said to be centered if all elements (except the middle one) are strictly greater than the value of the middle element. Note that only arrays with an odd number of elements have a middle element. Write a function that accepts an integer array and returns 1 if it is a centered array, otherwise it returns 0.
        */
        // static int centeredElement(int[] number) {
        //     //check the lenght of array
        //     int lenght = number.Length;

        //     int count_lowest_numbers = 0;

        //     int count_middle_element = 0;
        //     int middle_element = 0;

        //     if (lenght > 1 || lenght == 1) // array element more than 1 or equal to 1
        //     {

        //         if (lenght == 1)
        //         { // only 1 element
        //             Console.WriteLine("The length of the element in the array is old that is 1, therefore the Array is Centered. The result is 1 ");
        //             return 1;
        //         }

        //         if (lenght % 2 == 0)
        //         { // number of elements in the array is even
        //             Console.WriteLine("The length of the element in the array is an even that is " + lenght + ", therefore the Array is not Centered. The result is 0 ");
        //             return 0;
        //         }
        //         else
        //         {
        //             int whole_number = lenght / 2; // get the interger part of the division 
        //             for (int i = 0; i < lenght; i++)
        //             {
        //                 middle_element = number[whole_number]; // get the element at the middle of the array
        //                 if (middle_element == number[i])
        //                 {
        //                     // count how many times middle element equal to any of the element
        //                     count_middle_element++;
        //                 }
        //                 else
        //                 {

        //                     if (middle_element < number[i])  //middle number is less all other elements in the array
        //                     {
        //                         count_lowest_numbers++;
        //                     }

        //                 }
        //             }
        //         }
        //     }
        //     else
        //     {
        //         return 0;
        //     }

        //     if (count_middle_element > 1) // check middle elemeent duplicates
        //     {
        //         Console.WriteLine("The array is not centered because the middle element " + middle_element + " is not strictly less than all other elements. The result is 0 ");
        //         return 0;
        //     } else if (count_lowest_numbers == lenght - 1) //compare the number element less than middle elmenet with total number of elemen in the array minus 1
        //     {
        //         Console.WriteLine("The array is centered because the middle element " + middle_element + " is strictly less than all other elements. The result is 1 ");
        //         // Console.WriteLine("Result  == " + count_lowest_numbers + "  compared to  " + lenght -1);
        //         return 1;
        //     } else {
        //         Console.WriteLine("The array is not centered because the middle element " + middle_element + " is not strictly less than all other elements. The result is 0 ");
        //         return 0;
        //     }

        // }


        // static int sumOfOddAndEvenNumber(int[] numbers) {
        //     /**
        //     Write a function that takes an array of integers as an argument and returns a value based on the sums of the even and odd numbers in the array. Let X = the sum of the odd numbers in the array and let Y = the sum of the even numbers. The function should return X – Y
        //     */

        //     int sum_odd_numbers = 0; int sum_even_numbers = 0;
        //     int length = numbers.Length;
        //     int result = 0;

        //     for (int counter = 0; counter < length; counter++) {
        //         if (numbers[counter] % 2 == 0)
        //         {
        //             //the number is even
        //             sum_even_numbers += numbers[counter];
        //         }
        //         else
        //         {
        //             //the number is even
        //             sum_odd_numbers += numbers[counter];
        //         }
        //     }

        //     result = sum_odd_numbers - sum_even_numbers;

        //     Console.WriteLine("The result is: " + sum_odd_numbers + " - " + sum_even_numbers + " = " + result);
        //     return result;

        // }


        // static char[] lengthCharacter(char[] letters, int start, int len) {

        //     /*
        //         Write a function that accepts a character array, a zero-based start position and a length. It should return a character array containing containing lengthcharacters starting with the startcharacter of the input array. The function should do error checking on the start position and the length and return null if the either value is not legal.
        //         The function signature is:
        //         char[ ] f(char[ ] a, int start, int len)
        //     */

        //     char[] result = { };
        //     int lenght = letters.Length;
        //     if ((len - start) > lenght) {
        //         return null;
        //     } else {

        //         // foreach(char letter in letters){
        //         //     result
        //         // }
        //         return letters;

        //     }

        // }

        // static int pointOfEequilibrium(int[] numbers)
        // {

        //     int length = numbers.Length;
        //     int fwdsum = numbers[0];
        //     int bwdsum = 0;
        //     int output = 0;

        //     for (int i = 0; i < length; i++)
        //     {

        //         fwdsum + numbers[i];
        //         if (fwdsum == numbers[length - 1] + )
        //             fwdsum += numbers[i];
        //         Console.WriteLine("iterate i no : " + i);
        //         for (int j = length - 1; j >= 0; j--) {
        //             Console.WriteLine("iterate  j no : " + j);
        //             bwdsum += numbers[j];
        //         }

        //         output = i;

        //         if (fwdsum == bwdsum) {
        //             Console.WriteLine("iterate no 1: " + fwdsum + "bwd sum " + bwdsum);
        //             return output;
        //         } else {
        //             Console.WriteLine("iterate no 1: " + fwdsum + "bwd sum " + bwdsum);
        //             return -1;
        //         }
        //     }
        //     return output;




        // }

        



        // static int countDimples(int[] a)
        // {
        //     int size = a.Length;
        //     int countDimple = 0;

        //     //arry size must at least 3 elements
        //     if (size > 2)
        //     {
        //         for (int i = 1; i < size - 1; i++)
        //         {
        //             //compare element before and after
        //             if (a[i] < a[i - 1] && a[i] < a[i + 1])
        //             {

        //                 countDimple++;
        //             }
        //         }
        //     }

        //     if (countDimple > 0)
        //         return countDimple;

        //     else
        //         return 0;

        // }
    }
        



    
}

using System;

namespace _03.checkIfAllNumbersPositive
{
    class PositiveNumbers
    {
        static bool AreAllPositive(int[] sequence) //here we can call the method AreAllPositive with array of numbrs!
        {
            foreach (int number in sequence)
            {
                Console.WriteLine(number);
                if (number <= 0)
                {
                    //Console.WriteLine(number);
                    return false;
                }
                
            }
            return true;
            //the method retuns bool values, the method receives a int elements Array
                        //ArePositive  Method returns true when all numbers in the Array called sequence are > 0;
                        // if we have only one number that is negative then the method ArePositive() retuns false / 
                        // Cann we have many return statements in a method -yes is the answer, 
                        //here we are not sure which return will be executed, we have to check it; if return i false then it break the whole method
        }
        //static bool AreAllPositive(int n)//method overloading, we call a method with different parametrs into class
        //{
        //    return n > 0;
        //}
        static void Main() 
        {
            Console.Write("number of elements ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("int[{0}] = ", i);
                
                array[i] = int.Parse(Console.ReadLine());
            }

            bool allPositive = AreAllPositive(array);
            if (allPositive)
            {
                Console.WriteLine("All array elements are positive. ");
            }
            else
            {
                Console.WriteLine("Not all array elements are positive .");
            }
        }
    }
}

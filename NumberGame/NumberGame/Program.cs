using System;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartSequence();
        }

        static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your answer is  {answer}");
            int[] inputArr = new int[answer];
            Populate(inputArr);
           int sum = GetSum(inputArr);
            Console.WriteLine("The sum of the array is {0}", sum);
            /*int product = GetProduct(InputArr,sum);
            decimal quotient =  GetQuotient(product);*/
     
           
        }   
        // populates the array with numbers the user inputs
        static int[] Populate(int[] arr)
        {
            Console.WriteLine(" The size of your array is {0} ", arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Please enter {0} of {1} " , i + 1 , arr.Length);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            return arr;
        }

        // Gets the sum of all the number in the array
        static int GetSum(int[] arr)
        {
            int sum = 0;
            int sumMin = 20;

            for (int i = 0; i < arr.Length; i++)
            {
                int oneArr = arr[i];
                sum += oneArr;
            }
            if (sum < sumMin)
            {
                throw(new Exception($"Value of {sum} is too low"));
            }
            return sum;
        }
    }
}

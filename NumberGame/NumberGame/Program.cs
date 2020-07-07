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
            int product = GetProduct(inputArr,sum);
            Console.WriteLine($"{sum} * {product/sum} = {product}");
            /*decimal quotient =  GetQuotient(product);*/
     
           
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

        // get the product of the sum of the array and the value of the index user chooses
        static int GetProduct(int[] arr , int arrSum)
        {
            try
            {
                Console.WriteLine("Select a random number from 1 to {0} ", arr.Length);
                int userInput = Convert.ToInt32(Console.ReadLine());
                int product = arr[userInput] * arrSum;
                return product;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}

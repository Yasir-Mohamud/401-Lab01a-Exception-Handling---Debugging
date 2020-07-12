using System;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            catch (Exception e)
            {
                Console.WriteLine("There seems to be a problem");
                Console.WriteLine(e); 
            } 
            finally
            {
                Console.WriteLine("Program is complete");
            }
        }

        static void StartSequence()
        {
            Console.WriteLine("Welcome to my game! Let's do some math!");
            Console.WriteLine("Enter a number greater than zero");
            int answer = Convert.ToInt32(Console.ReadLine());
            int[] inputArr = new int[answer];
            Populate(inputArr);
           int sum = GetSum(inputArr);
            int product = GetProduct(inputArr, sum);
            decimal quotient = GetQuotient(product);

            Console.WriteLine("Your array size is {0}", inputArr.Length);
            Console.WriteLine($"The numbers in the array are {string.Join(", " , inputArr)}");
            Console.WriteLine($"The sum of the array is {sum}");
            Console.WriteLine($"{sum} * {product / sum} = {product}");
            Console.WriteLine($"{product} / {product / quotient} = {quotient}");
            Console.ReadLine();
           
        }   
        // populates the array with numbers the user inputs
        static int[] Populate(int[] arr)
        {
           
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
                int product = arr[userInput - 1] * arrSum;
                return product;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine($"Please enter a number to divide your product {product} by ");
                int userInput = int.Parse(Console.ReadLine());
             
                decimal quotient = decimal.Divide(product, userInput);
                return quotient;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
                return 0;
            }
          


        }
    }
}

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
           /* int sum = GetSum(InputArr);
            int product = GetProduct(InputArr,sum);
            decimal quotient =  GetQuotient(product);*/
     
           
        }   
        
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
    }
}

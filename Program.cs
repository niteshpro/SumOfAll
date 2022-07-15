//2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

namespace loops
{
    class Program
    {
        static void Main()
        {
            var sum=0;

            while (true)
            {
                Console.WriteLine("Enter a number (or OK to EXIT)");
                var input = Console.ReadLine();

                if(input.ToLower() == "ok")
                {
                    break;
                }
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all the numbers is: {0} ",sum);
        }
    }
}
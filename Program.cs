namespace Conditional_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number: ");
            int nl = Convert.ToInt32(Console.ReadLine());

            //IF/ ELSE IF/ ELSE
            if (nl > 1000)
            {
                Console.WriteLine("The input is greater than 1000");
            }
            else if ((nl > 500) && (nl <= 1000))
            {
                Console.WriteLine("The input is between 500 and 1000");
            }
            else
            {
                Console.WriteLine("The input is less than 1000");
            }
            //Switch

            Console.WriteLine("Enter the second integer number: ");
            int n2 = int.Parse(Console.ReadLine());

            switch (n2)    
            {
                case 0:
                    Console.WriteLine("Input is 0");
                    Console.ReadKey();
                    break;
                    
                case 1:
                    Console.WriteLine("Input is 1");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Input is 2 ");
                    Console.ReadKey();
                    break;

                default: Console.WriteLine("Input is not in range [0,2]");
                    Console.ReadKey();
                    break;
            }

            // Try-catch
            try 
            {
                Console.WriteLine("Enter the third number: ");
                string input = Console.ReadLine();
                int n3 = int.Parse(input);
                Console.WriteLine(" The input is: " + n3);
            }


            catch
            {
                Console.WriteLine("Please use an integer number");
                Console.ReadKey(true);
            }


        }
    
    }

}
namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Restocking Tool");
            Console.WriteLine();

            Console.WriteLine("How many sodas have been sold today? 100 are in stock");
            Console.ReadLine();
            int x = 100;
            int y = 60;
            Console.WriteLine("There are " + (x - y) + " sodas left");

            Console.WriteLine("How many Chips have been sold today? 40 are in stock");
            Console.ReadLine();
            int a = 40;
            int b = 20;
            Console.WriteLine("There are " + (a - b) + " chips left");

            Console.WriteLine("How much candy have been sold today? 60 are in stock");
            Console.ReadLine();
            int c = 60;
            int d = 20;
            Console.WriteLine("There are " + (c - d) + " candies left");

            Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");
            Console.WriteLine();

            int number = 40;
            if (number <= 40)
            {
                Console.WriteLine((x - y) + " sodas needs to be restocked");
            }

            int number2 = 20;
            if (number2 <= 20)
            {
                Console.WriteLine((a - b) + " chips needs to be restocked");
            }

            int number3 = 40;
            if (number3 <= 40)
            {
                Console.WriteLine((c - d) + " candies needs to be restocked");
            }

            int number4 = 30;
            if (number >= 30)
            {
                Console.WriteLine((c - d) + " That value is too high. Stock not adjusted ");
            }
            int number5 = 10;
            if (number2 >= 10)
            {
                Console.WriteLine((a - b) + " That value is too high. Stock not adjusted");
            }
            int number6 = 20;
            if (number3 >= 20)
            {
                Console.WriteLine((x - y) + " That value is too high. Stock not adjusted");
            }


        }
    }
}

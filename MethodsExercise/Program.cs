namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what is your name.");
            string name = Console.ReadLine(); // input
            Console.WriteLine("what is your favorite show.");
            string show = Console.ReadLine(); // input
            Console.WriteLine("what is your favorite month of the year.");
            string month = Console.ReadLine(); // input
            Console.WriteLine("what is your favorite color.");
            string color = Console.ReadLine(); // input
            Console.WriteLine("who was your favorite pet.");
            string pet = Console.ReadLine(); // input

            Console.WriteLine($"{name} didnt know that {show} new season started in {month}.");
            Console.WriteLine($"She loved to wear her {color} {show} shirt while she walked {pet}.");
            // Addition:
            // Subtraction:
            // Multiplication:
            // Division:
                
            Console.WriteLine(Add(14, 7)); // Output: 21
            Console.WriteLine(Subtract(175, 52)); // Output: 123
            Console.WriteLine(Multiply(45, 8)); // Output: 360
            Console.WriteLine(Divide(78, 3)); // Output 26
            
            
        }
        
        // Exercise2
        
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
        
}


   
            
        
}

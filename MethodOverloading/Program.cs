namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool c)
        {
            if (c && (a + b) != 1)
            {
                return $"{a + b} dollars";
            }
            else if (c && (a + b) == 1)
            {
                return $"{a + b} dollar";
            }
            else
            {
                return $"{a + b}";
            }
        }
    
        
        
            
        
    }
}

namespace Avans_SOA_3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Hello, World!");
                Console.WriteLine("Usage: dotnet run -- [arguments...]");
                Console.WriteLine("Example: dotnet run -- arg1 arg2 arg3");
            }
            else
            {
                Console.WriteLine($"Received {args.Length} command-line argument(s):");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"  [{i}]: {args[i]}");
                }
            }
        }
    }
}

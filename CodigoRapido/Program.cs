internal class Program
{
    private static void Main(string[] args)
    {
        // diagonal problem

        int negative = 0;
        
        int q = int.Parse(Console.ReadLine() ?? string.Empty);
        int[,] n = new int[q, q];
        for (int x = 0; x < q; x++)
        {
            var c = Console.ReadLine().Split(' ');
            for (int y = 0; y < q; y++)
            {
                n[x, y] = int.Parse(c[y]);
            }
        }

        Console.WriteLine();
        
        for (int x = 0; x < q; x++)
        {
            Console.WriteLine($"Main diagonal {x + 1}#: {n[x,x]}");
        }

        for (int x = 0; x < q; x++)
        {
            for (int y = 0; y < q; y++)
            {
                if (n[x, y] < 0)
                {
                    negative += n[x, y];
                }
            }
        }

        Console.WriteLine($"Negative numbers: {negative}");
    }
}
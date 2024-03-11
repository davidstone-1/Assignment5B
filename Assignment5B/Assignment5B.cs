using System;

namespace Assignment5B
{
    class Program
    {
        int UpdateAmount = 5;
        static void Main(string[] args)
        {
            Console.Write("Enter a level map width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter a level map height: ");
            int height = int.Parse(Console.ReadLine());

            // Initlize the map
            char[,] map = Initializemap(width, height);

            // Print the initialized map
            Printmap(map, width, height);
            
        }

        // This is the Method to initialize the map with underscores
        static char[,] Initializemap(int width, int height)
        {
            char[,] map = new char[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    map[i, j] = '_';
                }
            }

            return map;
        }
        static void Printmap(char[,] map, int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
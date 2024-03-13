﻿using System;
using System.Xml.Linq;
namespace Assignment5B
{
    class Program
    {
        public static int PlatformLength { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("[FYE Level Map Creator]");

            Console.Write("Enter a level map width: ");
            var width = int.Parse(Console.ReadLine());
            Console.Write("Enter a level map height: ");
            var height = int.Parse(Console.ReadLine());

            // Initlize the map
            char[,] map = Initializemap(width, height);

            // Print the initialized map
            Printmap(map, width, height);
            var Selection = 0;
            while (Selection != 4)
            {
            Console.WriteLine();
            Console.WriteLine("Options");
            Console.WriteLine("1. Clear Level");
            Console.WriteLine("2. Add Platform");
            Console.WriteLine("3. Add Items");
            Console.WriteLine("4. Quit");
            Console.Write("Enter a choice: ");

            Selection = int.Parse(Console.ReadLine());
            if (Selection == 1)
            {
                Console.WriteLine();
                Console.WriteLine("[Clear Level]");
                Printmap(Initializemap(width, height), width, height);
            }

            if (Selection == 2)
            {
                Console.WriteLine();
                Console.WriteLine("[Add Platform]");

                Console.Write("Enter X Coordinate: ");
                int Xcord = int.Parse(Console.ReadLine());

                Console.Write("Enter Y Coordinate: ");
                int Ycord = int.Parse(Console.ReadLine());

                Console.Write("Enter Length: ");
                int PlatformLength = int.Parse(Console.ReadLine());
                if (PlatformLength > width)
                {
                    Console.WriteLine("This platform won’t fit in the level!");
                }
                else
                {
                    AddPlatform(map, Xcord, Ycord, PlatformLength, width, height);
                    Console.WriteLine();
                }
                Printmap(map, width, height);
            }

            if (Selection == 3)
            {
                static void WriteToMap(char[,] map, int x, int y, char value)
                {
                    if (x >= 0 && x < map.GetLength(1) && y >= 0 && y < map.GetLength(0))
                    {
                        map[y, x] = value;
                    }
                    else 
                    {
                        Console.WriteLine("This is not a valid location!");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("[Add Item]");
                Console.Write("Enter X Coordinate: ");
                int Xcord = int.Parse(Console.ReadLine());

                Console.Write("Enter Y Coordinate: ");
                int Ycord = int.Parse(Console.ReadLine());
                WriteToMap(map, Xcord, Ycord, 'P');
                Printmap(map, width, height);
            }
            }
            if (Selection == 4)
            {
                Console.WriteLine();
                Printmap(Initializemap(width, height), width, height);
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
            }
        }
        static void AddPlatform(char[,] map, int xCord, int yCord, int PlatformLength, int width, int height)
        {
            for (int i = 0; i < PlatformLength; i++)
            {
                if (xCord + i < width && yCord < height)
                {
                    map[yCord, xCord + i] = '=';
                }
            }
        }
        static void Additem(char[,] map, int Xcord, int Ycord, int width, int height)
        {

            Console.WriteLine("Enter Length: ");
            var PlatformLength = int.Parse(Console.ReadLine());
            for (int i = 0; i < PlatformLength; i++)
            {
                if (Xcord + i < PlatformLength && Ycord < height)
                {
                    map[Ycord, Xcord + i] = '=';
                }
            }

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
        // Method to print the map to the console
        public static void Printmap(char[,] map, int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine("_");
            }
        }
    }
}
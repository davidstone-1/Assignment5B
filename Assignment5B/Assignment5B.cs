﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Assignment5B
{
    class Program
    {
        public static int platformLength { get; private set; }

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
            var Selection = 0;
            while (Selection != 4)
            {
            Console.WriteLine("Options");
            Console.WriteLine("1. Clear Level");
            Console.WriteLine("2. Add Platform");
            Console.WriteLine("3. Add Items");
            Console.WriteLine("4. Quit");
            Console.Write("Enter a choice: ");

            Selection = int.Parse(Console.ReadLine());
            if (Selection == 1)
            Console.WriteLine("[Clear Level]");
            {
                Initializemap(width, height);
            }

            if (Selection == 2)
            {
                Console.WriteLine("[Add Platform]");

                Console.Write("Enter X Coordinate: ");
                int Xcord = int.Parse(Console.ReadLine());

                Console.Write("Enter Y Coordinate: ");
                int Ycord = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Length: ");
                var platformLength = int.Parse(Console.ReadLine());
                if (platformLength > width)
                {
                    Console.WriteLine("This platform won’t fit in the level!");
                }

                AddPlatform(map, Xcord, Ycord, width, height);
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
                Console.WriteLine("Goodbye!");
            }


            
        }
        static void AddPlatform(char[,] map, int Xcord, int Ycord, int width, int height)
        {  
            for (int i = 0; i < platformLength; i++)
            {
                if (Xcord + i < width && Ycord < height);
                {
                    map[Ycord, Xcord + i] = '=';
                }
            }

        }

        static void Additem(char[,] map, int Xcord, int Ycord, int width, int height)
        {

            Console.WriteLine("Enter Length: ");
            var platformLength = int.Parse(Console.ReadLine());
            for (int i = 0; i < platformLength; i++)
            {
                if (Xcord + i < width && Ycord < height)
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
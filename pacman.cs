/*
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Threading;
class Program56
{
    static void Main()
    {
        //Console.SetWindowSize(60, 15);
        Console.CursorVisible = false;
        char[,] map = ReadMap("D:/C# Studying/bin/Debug/net8.0/map.txt");
        bool gameIsWorking = true;
        ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);

        Task.Run(() => 
        {
            while(gameIsWorking)
            {
                pressedKey = Console.ReadKey();
            }
        });
        int pacmanX = 23;
        int pacmanY = 2;
        int health = 3;
        int score = 0;
        string pacmanIcon = "O";
        while(gameIsWorking)
        {
            
            Console.Clear();

            HandleInput(pressedKey, ref pacmanX, ref pacmanY, map, ref score, ref health, ref gameIsWorking, ref pacmanIcon);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            DrawMap(map);

            Console.SetCursorPosition(pacmanX, pacmanY);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(pacmanIcon); 

            Console.SetCursorPosition(55, 2);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Score: {score}");

            Console.SetCursorPosition(55, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Health: {health}");
            
            Thread.Sleep(250);


            Console.Clear();

            HandleInput(pressedKey, ref pacmanX, ref pacmanY, map, ref score, ref health, ref gameIsWorking, ref pacmanIcon);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            DrawMap(map);

            Console.SetCursorPosition(pacmanX, pacmanY);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("O"); 

            Console.SetCursorPosition(55, 2);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Score: {score}");

            Console.SetCursorPosition(55, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Health: {health}");
            
            Thread.Sleep(250);


        }
        Console.Clear();
        Console.SetCursorPosition(0,0);
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine("Игра окончена. \nСпасибо, за то что поиграли!");
        System.Console.WriteLine("(нажмите любую клавишу чтобы продолжить)");
        Console.ReadKey();
        Console.Clear();
    }
    
    private static void DrawMap(char[,] map)
    {
        for(int y = 0; y < map.GetLength(1); y++)
        {
            for(int x = 0; x < map.GetLength(0); x++)
            {
                Console.Write(map[x, y]);
            }
            Console.WriteLine();
        }
    }
    private static char[,] ReadMap(string path)
    {
        string[] file = File.ReadAllLines(path);
        int maxLength = file.Max(s => s.Length);
        char[,] map = new char[maxLength, file.Length];
        for (int y = 0; y < file.Length; y++)
        {
            for (int x = 0; x < maxLength; x++)
            {
                if (x < file[y].Length)
                {
                    map[x, y] = file[y][x]; 
                }
                else
                {
                    map[x, y] = ' ';
                }
            }
        }
        return map;
    }
    private static int GetLengthOfLines(string[] lines)
    {
        int maxLength = 0;
        foreach(var line in lines)
        {
            maxLength = Math.Max(line.Length, maxLength);
        }
        return maxLength;
    }
    private static void HandleInput(ConsoleKeyInfo pressedKey,  ref int pacmanX, ref int pacmanY, char[,] map, ref int score, ref int health, ref bool gameIsWorking, ref string pacmanIcon)
    {
        int[] direction = GetDirection(pressedKey, ref pacmanIcon);
        int nextPacmanPositionX = pacmanX + direction[0];
        int nextPacmanPositionY = pacmanY + direction[1];
        if(map[nextPacmanPositionX, pacmanY] == '#' || map[pacmanX, nextPacmanPositionY] == '#')
        {
            pacmanX = pacmanX;
            pacmanY = pacmanY;
        }
        else if(map[nextPacmanPositionX, pacmanY] == '%' || map[pacmanX, nextPacmanPositionY] == '%')
        {
            pacmanX = pacmanX;
            pacmanY = pacmanY;
            health -= 1;
        }
        else
        {
            pacmanX = nextPacmanPositionX;
            pacmanY = nextPacmanPositionY;
        }
        if(map[nextPacmanPositionX, pacmanY] == '.' || map[pacmanX, nextPacmanPositionY] == '.')
        {
            pacmanX = nextPacmanPositionX;
            pacmanY = nextPacmanPositionY;
            score++;
            map[nextPacmanPositionX, nextPacmanPositionY] = ' ';
        }

        if(health < 1)
        {
            gameIsWorking = false;
        }

    }
    private static int[] GetDirection(ConsoleKeyInfo pressedKey, ref string pacmanIcon)
    {
        int[] direction = {0,0};
        if(pressedKey.Key ==  ConsoleKey.UpArrow)
        {
            direction[1] -= 1;
            pacmanIcon = "v";
        }    
        else if(pressedKey.Key == ConsoleKey.DownArrow)
        {
            direction[1] += 1;
            pacmanIcon = "^";
        }
        else if(pressedKey.Key == ConsoleKey.LeftArrow)
        {
            direction[0] -=1;
            pacmanIcon = ">";
        }
        else if(pressedKey.Key == ConsoleKey.RightArrow)
        {
            direction[0] += 1;
            pacmanIcon = "<";
        }
        return direction;
    }   
}
*/
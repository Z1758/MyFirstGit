﻿namespace FirstGit
{
    internal class Program
    {
        struct Player
        {
            public string name;
            public int level;
        }

        struct Monster
        {
            public string name;
            public int hp;
        }

        struct Item
        {
            public string name;
        }

        static void Main(string[] args)
        {
            Player player = new Player() { name = "용사", level = 1 };
            Monster monster = new Monster(){ name = "오크", hp = 10 };

            Console.WriteLine("Hi");
        }
    }
}

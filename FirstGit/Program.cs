namespace FirstGit
{
    internal class Program
    {
        struct Player
        {
            public string name;
            public int level;
        }
        static void Main(string[] args)
        {
            Player player = new Player() { name = "용사", level = 1 };
        }
    }
}

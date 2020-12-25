using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game() { GameId = 1, GameName = "Clash of clans", GameType = new GameType() { TypeName = "Mobile" }, State = true };
            ShowDetail(game,false);

            Game clonedGame = (Game)game.Clone();
            ShowDetail(clonedGame,true);
            clonedGame.GameType.TypeName = "Windows";
            clonedGame.GameName = "World of Tanks";
            ShowDetail(game,false)
                ;
            Console.ReadKey();

        }

        public static void ShowDetail(Game game, bool cloned)
        {
            if (!cloned)
            {
                Console.WriteLine($"The Original Game: {game.GetHashCode()}:");
                Console.WriteLine("\tGame Id: " + game.GameId);
                Console.WriteLine("\tGame Name: " + game.GameName);
                Console.WriteLine($"\tThe Original GameType {game.GameType.GetHashCode()}:");
                Console.WriteLine("\t\tType Name: " + game.GameType.TypeName);
                Console.WriteLine("\tGame State: " + game.State);
                Console.WriteLine("------------------------------------------------------------------------\n");
            }
            if (cloned)
            {
                Console.WriteLine($"The Clone Game: {game.GetHashCode()}:");
                Console.WriteLine("\tGame Id: " + game.GameId);
                Console.WriteLine("\tGame Name: " + game.GameName);
                Console.WriteLine($"\tThe Clone GameType {game.GameType.GetHashCode()}:");
                Console.WriteLine("\t\tType Name: " + game.GameType.TypeName);
                Console.WriteLine("\tGame State: " + game.State);
                Console.WriteLine("------------------------------------------------------------------------\n");
            }
        }

    }
}

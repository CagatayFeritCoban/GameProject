using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("game" + game.GameName + "Added to Store");
        }
        public void DeleteGame(Game game)
        {
            Console.WriteLine("game" + game.GameName + "Deleted from the store");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteczka
{
    public class Library
    {
        private List<Game> _gamesList;

        public Library()
        {
            _gamesList = new List<Game>();
        }

        public void AddGameToList(Game item)
        {
            if (!_gamesList.Contains(item))
            {
                _gamesList.Add(item);
            }
        }

        public void RemoveGame(Game game)
        {
            _gamesList.Remove(game);
            SaveGamesToFile();
        }

        public List<Game> GetGames()
        {
            return _gamesList;
        }

        public void ImportGamesFromFile()
        {
            _gamesList.Clear();
            using (StreamReader sr = new StreamReader(@"C:\Users\Latandu\Documents\biblioteka.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parameters = line.Split('|');
                    Game game = new Game(parameters[0], int.Parse(parameters[1]), decimal.Parse(parameters[2]), parameters[3]);
                    AddGameToList(game);
                }
            }
        }

        public void SaveGamesToFile()
        {
            using (StreamWriter sw  = new StreamWriter(@"C:\Users\Latandu\Documents\biblioteka.txt"))
            {
                foreach (Game game in _gamesList)
                {
                    sw.WriteLine("{0}|{1}|{2}|{3}", game._title, game._ageLimit, game._price, game._description);
                }
            }
        }
    }
}

using System.Collections.Generic;
using SQLite;
using ChuckNorrisJokes.Models;

namespace ChuckNorrisJokes
{
    public class JokeDatabase
    {
        readonly SQLiteConnection _database;

        public JokeDatabase()
        {
            _database = DependencyService.Get<ISQLite>().GetConnection();
            _database.CreateTable<Joke>();
        }

        public List<Joke> GetJokes()
        {
            return _database.Table<Joke>().ToList();
        }

        public void SaveJoke(Joke joke)
        {
            _database.Insert(joke);
        }

        public void UpdateJoke(Joke joke)
        {
            _database.Update(joke);
        }

        public void DeleteJoke(Joke joke)
        {
            _database.Delete<Joke>(joke.Id);
        }
    }
}
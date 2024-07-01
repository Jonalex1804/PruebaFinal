using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using ChuckNorrisJokes.Models;

namespace ChuckNorrisJokes.ViewModels
{
    public class JokesViewModel : BaseViewModel
    {
        private readonly JokeDatabase _database;

        public ObservableCollection<Joke> Jokes { get; set; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public JokesViewModel()
        {
            _database = new JokeDatabase();

            Jokes = new ObservableCollection<Joke>(_database.GetJokes());

            EditCommand = new Command<Joke>(EditJoke);
            DeleteCommand = new Command<Joke>(DeleteJoke);
        }

        private void EditJoke(Joke joke)
        {
            // Implementación para editar un chiste en la base de datos
            _database.UpdateJoke(joke);
        }

        private void DeleteJoke(Joke joke)
        {
            // Implementación para eliminar un chiste de la base de datos
            _database.DeleteJoke(joke);
            Jokes.Remove(joke);
        }
    }
}

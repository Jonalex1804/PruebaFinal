
using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace ChuckNorrisJokes.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly JokeDatabase _database;

        public ICommand GetNewJokeCommand { get; }

        public MainViewModel()
        {
            _database = new JokeDatabase();

            GetNewJokeCommand = new Command(GetNewJoke);
        }

        private async void GetNewJoke()
        {
            // Lógica para obtener el chiste desde la API y guardar en SQLite
            var joke = await ChuckNorrisApiService.GetRandomJoke();

            // Generar el código
            var random = new Random();
            var code = $"SC{random.Next(1000, 2000)}"; // Ejemplo: SC1089

            joke.Code = code;

            // Guardar en la base de datos
            _database.SaveJoke(joke);

            // Mostrar mensaje de confirmación
            await App.Current.MainPage.DisplayAlert("Nuevo Chiste Guardado", "Se ha guardado un nuevo chiste.", "OK");
        }
    }
}

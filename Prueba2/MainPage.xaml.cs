using Microsoft.Maui.Controls;
namespace ChuckNorrisJokes.Views

{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel ();

            var stackLayout = new StackLayout ();
            var button = new Button { Text = "Obtener Nuevo Chiste" };
            button.SetBinding(Button.CommandProperty, new Binding("GetNewJokeCommand"));

           stackLayout.Children.Add(button);
            Content = stackLayout;
        }
    }

}

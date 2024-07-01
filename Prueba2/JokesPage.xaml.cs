using Microsoft.Maui.Controls;
using ChuckNorrisJokes.ViewModels;

 namespace ChuckNorrisJokes.Views;
{


	public partial class JokesPage : ContentPage
	{
		public JokesPage()
		{
			InitializeComponent();
			BindingContext = new JokesViewModel();

		}
	}
 }
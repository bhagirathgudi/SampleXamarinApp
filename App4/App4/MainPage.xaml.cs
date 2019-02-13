using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
	public partial class MainPage : ContentPage
	{
		private string textInput;
		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			DisplayAlert("Hola, you entered", textInput, "Ok");	
		}

		private void Editor_Completed(object sender, EventArgs e)
		{
			Editor editor = (Editor)sender;
			textInput = editor.Text;
		}

		private void Editor_TextChanged(object sender, TextChangedEventArgs e)
		{
			Editor editor = (Editor)sender;
			textInput = editor.Text;
		}
	}
}

using Android.Content.Res;
using AtividadeKaique.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace AtividadeKaique
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new Navegacao(new MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			
	
			
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

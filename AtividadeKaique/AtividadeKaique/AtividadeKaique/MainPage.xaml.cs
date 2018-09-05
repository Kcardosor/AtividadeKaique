using AtividadeKaique.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AtividadeKaique
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		public void MeuAlerta(Object obj, EventArgs sender)
		{
			Navigation.PushAsync(new Pagina1());
		}

		public void MeuAlerta1(Object obj, EventArgs sender)
		{
			Navigation.PushAsync(new Pagina2());		
		}
		public void MeuAlerta2(Object obj, EventArgs sender)
		{
			Navigation.PushAsync(new Pagina3());
		}
	}
}

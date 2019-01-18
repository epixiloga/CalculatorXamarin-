using FirstXmr1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstXmr1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyPage : ContentPage
	{
		public MyPage ()
		{
			InitializeComponent ();
			


			//IDialer dialer = DependencyService.Get<IDialer>();

			//if (dialer != null)
			//{
			//	var boolVal = dialer.MakeCall("0103455634");
			//	await DisplayAlert("totot", boolVal.ToString(), "OK");
			//}


				//var lUserApp = new Label()
				//{
				//	Text = "App M2I",
				//	TextColor = Color.Red,
				//	FontSize = 23,
				//	VerticalOptions = LayoutOptions.CenterAndExpand,
				//	HorizontalOptions = LayoutOptions.Center,
				//};

				//var lUserName = new Label()
				//{
				//	Text="Nom"
				//};

				//var EntryNom = new Entry()
				//{
				//	Placeholder="Entrez votre Nom"
				//};

				//StackLayout layout = new StackLayout();
				//layout.Children.Add(lUserApp);
				//layout.Children.Add(lUserName);
				//layout.Children.Add(EntryNom);


			}

		private void Button_Clicked(object sender, EventArgs e)
		{
			DisplayAlert("toto","Firstname: " + this.Firstname.Text.ToUpper() +
												"\nLastname: "+ this.Lastame.Text.ToUpper()+
												"\nAge: " + this.age.Text, "Valider");
		}
	}
}

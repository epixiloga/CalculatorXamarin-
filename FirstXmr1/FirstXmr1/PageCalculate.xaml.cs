using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstXmr1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageCalculate : ContentPage
	{
		public PageCalculate ()
		{
			InitializeComponent ();
		}

	
		private void Button_Clicked_num(object sender, EventArgs e)
		{
			var myButton = (Button)sender;
			this.num.Text += myButton.Text;

			//return int.Parse(this.num.Text);
		}

		private void Button_Clicked_operator(object sender, EventArgs e)
		{
			var myButton = (Button)sender;
			this.num.Text += myButton.Text;

		}
		private void Button_Clicked_calculate(object sender, EventArgs e)
		{
			var result = new DataTable().Compute(this.num.Text, "");
			this.num.Text = result.ToString();
		}

		private void Button_Clicked_clear(object sender, EventArgs e)
		{
			this.num.Text = "0";
		}
	}
}
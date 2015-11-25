using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinCSharp
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			Content = CreatePage ();
			InitializeComponent ();

		}

		public View CreatePage(){
		
			var outStackLayout = new StackLayout () {

				Padding = 30,
				Children = {

					new Label () {

						FontSize = 30,
						Text = "Order Form",
						HorizontalOptions = LayoutOptions.Center
					},

					new StackLayout () {

						Orientation = StackOrientation.Horizontal,
						Children = {
							new Label (){ Text = "Customer" },

							new Entry (){ Placeholder = "Full Name" }
						}

					},

					new Button () {

						Text = "Click Me"

					}
				}


			};
			return outStackLayout;
		
		
		}
	}
}


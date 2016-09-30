using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;

using Xamarin.Forms;

namespace TestingXamarin
{
	public class listPage : ContentPage
	{
		public listPage ()
		{
            ListView listView = new ListView
            {
                RowHeight = 40
            };

            listView.ItemsSource = new string[]
            {
                "Buy pears", "Buy oranges", "Buy mangos", "Buy apples", "Buy bananas"
            };

            listView.ItemSelected += async (sender, e) => {
                await DisplayAlert("Tapped!", e.SelectedItem + " was tapped.", "OK");
                await Navigation.PushAsync(new ClockPage());
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,
                Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        },
                        listView

                    }
            };

        }

        

        
	}
}

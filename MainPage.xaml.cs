using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = sender as Button;
            if (button.Equals(takeMeasurementsButton))
            {
                await Navigation.PushAsync(new TakeMeasurements());
            }
            else if (button.Equals(previousDataButton))
            {
                await Navigation.PushAsync(new PreviousData());
            }
            else if (button.Equals(educationalResourcesButton))
            {
                await Navigation.PushAsync(new EducationalResources());
            }
            /*else if (button.Equals(settingsButton))
            {
                await Navigation.PushAsync(new Settings());
            }*/
        }

    }
}

using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Utosoft.DeepLMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles selected text display on tapped event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SelectedTextDisplay_OnTapped(object sender, EventArgs e)
        {
            await Clipboard.SetTextAsync(SelectedTextDisplay.Text);
        }
    }
}

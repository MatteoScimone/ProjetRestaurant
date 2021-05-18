using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1Resteau1.Resteau;

namespace App1Resteau1
{
    public partial class MainPage : ContentPage
    {
        PlatRepository pltR;
       
        public MainPage()
        {
            InitializeComponent();
        }
       
        private async void newButton_Clicked(object sender, EventArgs e)
        {
            statutMessage.Text = "";

            await App.PlatRepository.AddNewPlatAsync(newPlat.Text);

            statutMessage.Text = App.PlatRepository.StatusMessage;

        }

        private async void getButton_Clicked(object sender, EventArgs e)
        {
            statutMessage.Text = "";

            List<Plat> plats = await App.PlatRepository.GetPlatsAsync();

            foreach (var plat in plats)
            {  
              Console.WriteLine($"{plat.Id} - {plat.Nom}");
            }
            statutMessage.Text = App.PlatRepository.StatusMessage;

        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            lvPlat.ItemsSource = await App.PlatRepository.GetPlatsAsync();
        }
    }
}

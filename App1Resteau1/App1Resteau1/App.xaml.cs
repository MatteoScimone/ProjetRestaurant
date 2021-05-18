using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.IO;
using App1Resteau1.Resteau;

namespace App1Resteau1
{
    public partial class App : Application
    {
        private string dbPath = Path.Combine(FileSystem.AppDataDirectory, "database.db3");
        
        public static PlatRepository PlatRepository { get; private set; }
        public App()
        {
            InitializeComponent();

            PlatRepository = new PlatRepository(dbPath);

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using RestaurantMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RestaurantWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Carte> mesCartes;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lvCartes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lvCartes.SelectedItem !=null)
            {
                lvMenus.ItemsSource = (lvCartes.SelectedItem as Carte).LesMenus;
            }
        }

        private void btnNoter_Click(object sender, RoutedEventArgs e)
        {
            if(lvPlats.SelectedItem == null)
            {
                MessageBox.Show("Sélectionner un plat", "Choix du plat", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else
            {
                (lvPlats.SelectedItem as Plat).NoterUnPlat(Convert.ToInt16(sldNote.Value));
                lvPlats.Items.Refresh();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Carte cartePrintemps = new Carte(1, "Carte de printemps");
            Carte carteHiver = new Carte(2, "Carte d'hiver");

            RestaurantMetier.Menu menuBio = new RestaurantMetier.Menu(1, "Menu Bio");
            RestaurantMetier.Menu menuVIP = new RestaurantMetier.Menu(1, "Menu VIP");
            RestaurantMetier.Menu menuGourmand = new RestaurantMetier.Menu(1, "Menu gourmand");

            Plat entree1 = new Plat(1, "Salade verte", 0, "Images/Salade.jpg");
            Plat entree2 = new Plat(2, "Escargots de bourgogne", 0, "Images/Escargot.jpg");
            Plat entree3 = new Plat(3, "Terrine de canard", 0, "Images/Terrine.jpg");
            Plat plat1 = new Plat(4, "Pièce du boucher", 0, "Images/Boucher.jpg");
            Plat plat2 = new Plat(5, "Poisson aux citrons", 0, "Images/Poisson.jpg");
            Plat plat3 = new Plat(6, "Pizza", 0, "Images/Pizza.jpg");
            Plat dessert1 = new Plat(7, "Tarte aux pommes", 0, "Images/Tarte.jpg");
            Plat dessert2 = new Plat(8, "Sorbet vanille", 0, "Images/Sorbet.jpg");
            Plat dessert3 = new Plat(9, "Gâteau chocolat", 0, "Images/Gateau.jpg");
            Plat dessert4 = new Plat(10, "Crème caramel", 0, "Images/Creme.jpg");

            menuBio.AjouterPlat(entree1); menuBio.AjouterPlat(plat2); menuBio.AjouterPlat(dessert2);
            
            menuVIP.AjouterPlat(entree1); menuVIP.AjouterPlat(entree2); menuVIP.AjouterPlat(plat1);
            menuVIP.AjouterPlat(dessert1); menuVIP.AjouterPlat(dessert4);

            menuGourmand.AjouterPlat(entree3); menuGourmand.AjouterPlat(plat3); menuGourmand.AjouterPlat(dessert3);

            carteHiver.AjouterMenu(menuGourmand); carteHiver.AjouterMenu(menuVIP);
            cartePrintemps.AjouterMenu(menuBio);


            mesCartes = new List<Carte>();
            mesCartes.Add(carteHiver); mesCartes.Add(cartePrintemps);

            lvCartes.ItemsSource = mesCartes;

        }

        private void lvMenus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvMenus.SelectedItem != null)
            {
                lvPlats.ItemsSource = (lvMenus.SelectedItem as RestaurantMetier.Menu).LesPlats;
                txtTotal.Content = (lvMenus.SelectedItem as RestaurantMetier.Menu).CalculerNote().ToString();
            }
        }

        private void sldNote_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtNote.Text = Convert.ToInt16(sldNote.Value).ToString();
            
                if (sldNote.Value <= 4)
            {
                LOLO.Source = new BitmapImage(new Uri("/ImagesSmiley/Bofe.png", UriKind.RelativeOrAbsolute));
            }
            else if (sldNote.Value >= 7)
            {
                LOLO.Source = new BitmapImage(new Uri("/ImagesSmiley/Content.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                LOLO.Source = new BitmapImage(new Uri("/ImagesSmiley/Moyen.png", UriKind.RelativeOrAbsolute));
            }

        }
    }
}

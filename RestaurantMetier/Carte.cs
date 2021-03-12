using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMetier
{
    public class Carte
    {
        private int idCarte;
        private string nomCarte;
        private List<Menu> lesMenus;

        public Carte(int unId,string unNom)
        {
            IdCarte = unId;
            NomCarte = unNom;
            LesMenus = new List<Menu>();
        }

        public int IdCarte { get => idCarte; set => idCarte = value; }
        public string NomCarte { get => nomCarte; set => nomCarte = value; }
        public List<Menu> LesMenus { get => lesMenus; set => lesMenus = value; }

        public void AjouterMenu(Menu nouveauMenu)
        {
            LesMenus.Add(nouveauMenu);
        }
    }
}

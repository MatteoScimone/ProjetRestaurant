using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMetier
{
    public class Menu
    {
        private int idMenu;
        private string nomMenu;
        private List<Plat> lesPlats;

        public Menu(int unId, string unNom)
        {
            IdMenu = unId;
            NomMenu = unNom;
            LesPlats = new List<Plat>();
        }

        public int IdMenu { get => idMenu; set => idMenu = value; }
        public string NomMenu { get => nomMenu; set => nomMenu = value; }
        public List<Plat> LesPlats { get => lesPlats; set => lesPlats = value; }

        public void AjouterPlat(Plat nouveauPlat)
        {
            LesPlats.Add(nouveauPlat);
        }

        public int CalculerNote()
        {
            int note = 0;
            foreach(Plat p in LesPlats)
            {
                note += p.NotePlat;
            }
            return note;
        }
    }
}

using System;

namespace RestaurantMetier
{
    public class Plat
    {
        private int idPlat;
        private string nomPlat;
        private int notePlat;
        private string imagePlat;

        public Plat(int unId, string unNom, int uneNote,string uneImage)
        {
            IdPlat = unId;
            NomPlat = unNom;
            NotePlat = uneNote;
            ImagePlat = uneImage;
        }

        public int IdPlat { get => idPlat; set => idPlat = value; }
        public string NomPlat { get => nomPlat; set => nomPlat = value; }
        public int NotePlat { get => notePlat; set => notePlat = value; }
        public string ImagePlat { get => imagePlat; set => imagePlat = value; }

        public void NoterUnPlat(int uneNote)
        {
            notePlat += uneNote;
        }
    }
}

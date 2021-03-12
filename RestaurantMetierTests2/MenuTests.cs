using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantMetier;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMetier.Tests
{
    [TestClass()]
    public class MenuTests
    {
        [TestMethod()]
        public void CalculerNoteTest()
        {
            Menu menu1 = new Menu(1, "Menu 1");

            Plat plat1 = new Plat(1, "Plat 1", 0, "ImagesPlat1");
            Plat plat2 = new Plat(2, "Plat 2", 4, "ImagesPlat1");
            Plat plat3 = new Plat(3, "Plat 3", 7, "ImagesPlat1");

            menu1.AjouterPlat(plat1); menu1.AjouterPlat(plat2); menu1.AjouterPlat(plat3);

            Assert.AreEqual(11, menu1.CalculerNote());
        }
    }
}
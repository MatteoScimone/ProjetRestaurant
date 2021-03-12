using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantMetier;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMetier.Tests
{
    [TestClass()]
    public class PlatTests
    {
        [TestMethod()]
        public void NoterUnPlatTest()
        {
            Plat p1 = new Plat(1, "Pizza", 0, "ImagePizza");
            p1.NoterUnPlat(5);
            Assert.AreEqual(5, p1.NotePlat);
            p1.NoterUnPlat(4);
            Assert.AreEqual(9, p1.NotePlat);
        }
    }
}

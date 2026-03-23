using Microsoft.VisualStudio.TestTools.UnitTesting;
using NASACLI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASACLI.Models.Tests
{
    [TestClass()]
    public class KuldetesTests
    {
        [DataRow(1.1, 11000, "Magas")]
        [DataRow(0.9, 11000, "Közepes")]
        [DataRow(1.1, 9000, "Közepes")]
        [DataRow(0.9, 9000, "Alacsony")]
        [TestMethod()]
        public void KockazatiSzintTest(double koltseg, double hasznosTeher, string elvart)
        {
            Kuldetes kuldetes = new($"Apollo 11;1969;Hold;3;Igen;Az első emberes holdraszállás;{koltseg};{hasznosTeher}");
            Assert.AreEqual(elvart, kuldetes.KockazatiSzint());
        }
    }
}
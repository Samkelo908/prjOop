using Microsoft.VisualStudio.TestTools.UnitTesting;
using prjOop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOop.Tests
{
    [TestClass()]
    public class ChickenBurgerTests
    {
        
        ChickenBurger cb = new ChickenBurger();
        [TestMethod()]

        public void ChickenBurgerTest()
        {
            string expected = "Chicken";
            Assert.AreNotEqual(expected, cb.getBun());
        }
    }
}
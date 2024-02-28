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
    public class VeggieBurgerTests
    {
       
        VeggieBurger veggieBurger = new VeggieBurger();
        [TestMethod]

        public void testBun()
        {
            veggieBurger.getBun();
            veggieBurger.getBun(optionOne: "Rice Flour");
            string expected = "Plain wheat";
            Assert.AreEqual(expected, veggieBurger.getBun());

        }
        [TestMethod]

        public void testPatty()
        {
            veggieBurger.getPatty();
            String expected = "Mushroom";
            Assert.AreEqual(expected, veggieBurger.getPatty());
        }

    }
}

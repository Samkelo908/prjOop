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
    public class CheeseBurgerTests
    {
        
        CheeseBurger cheeseBurger = new CheeseBurger();
        [TestMethod()]

        public void TestAddChedder()
        {
            string expectedChedder = "Chedder";
            Assert.AreEqual(expectedChedder, cheeseBurger.AddChedder());
        }
        [TestMethod()]

        public void testCheese() 
        {

            String expectedChadar = "Cheddar";
            Assert.AreEqual(expectedChadar, cheeseBurger.AddChedder());
            String expected = "Chadder";
            Assert.AreEqual(expected, cheeseBurger.AddChedder());
        }
    }
}
using System;
using CheeseburgerInheritance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheeseburgerTests.Inheritance
{
    [TestClass]
    public class CheeseburgerIlheusTest
    {
        private CheeseburgerIlheus cheeseburgerIlheus;
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestInitialize]
        public void Init()
        {
            this.cheeseburgerIlheus = new CheeseburgerIlheus();
        }

        [TestMethod]
        public void Description_Of_Cheeseburger_Ilheus()
        {
            Assert.AreEqual<string>("Bread, Hamburger, Cheese, Pepper Sauce", this.cheeseburgerIlheus.Description);
        }

        [TestMethod]
        public void Calories_Of_Cheeseburger_Ilheus()
        {
            Assert.AreEqual<int>(320, this.cheeseburgerIlheus.Calories());
            //Aqui eu não consigo assegurar que o método Calories da classe base foi chamado.
        }
    }
}

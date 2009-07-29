using System;
using CheeseburgerInheritance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheeseburgerTests.Inheritance
{
    [TestClass]
    public class CheeseburgerItarareTest
    {
        private CheeseburgerItarare cheeseburgerItarare;
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
            this.cheeseburgerItarare = new CheeseburgerItarare();
        }

        [TestMethod]
        public void Description_Of_Cheeseburger_Itarare()
        {
            Assert.AreEqual<string>("Bread, Hamburger, Cheese, Corn", this.cheeseburgerItarare.Description);
        }

        [TestMethod]
        public void Calories_Of_Cheeseburger_Itarare()
        {
            Assert.AreEqual<int>(370, this.cheeseburgerItarare.Calories());
            //Aqui eu não consigo assegurar que o método Calories da classe base foi chamado.
        }
    }
}

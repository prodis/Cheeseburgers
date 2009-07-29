using System;
using CheeseburgerInheritance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheeseburgerTests.Inheritance
{
    [TestClass]
    public class CheeseburgerTest
    {
        private Cheeseburger cheeseburger;
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
            this.cheeseburger = new Cheeseburger();
        }

        [TestMethod]
        public void Description_Of_Cheeseburger()
        {
            Assert.AreEqual<string>("Bread, Hamburger, Cheese", this.cheeseburger.Description);
        }
        
        [TestMethod]
        public void Calories_Of_Cheeseburger()
        {
            Assert.AreEqual<int>(300, this.cheeseburger.Calories());
        }
    }
}

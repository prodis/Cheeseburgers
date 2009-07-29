using System;
using CheeseburgerDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheeseburgerTests.Decorator
{
    [TestClass]
    public class CheeseburgerVariedTest
    {
        private Sandwich cheeseburger; 
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
        public void Itarare_Cheeseburger()
        {
            this.cheeseburger = new Corn(this.cheeseburger);

            Assert.AreEqual<string>("Bread, Hamburger, Cheese, Corn", this.cheeseburger.Description);
            Assert.AreEqual<int>(370, this.cheeseburger.Calories());
        }

        [TestMethod]
        public void Itarare_Cheeseburger_With_Onion_Rings()
        {
            this.cheeseburger = new Corn(this.cheeseburger);
            this.cheeseburger = new OnionRings(this.cheeseburger);

            Assert.AreEqual<string>("Bread, Hamburger, Cheese, Corn, Onion Rings", this.cheeseburger.Description);
            Assert.AreEqual<int>(510, this.cheeseburger.Calories());
        }

        [TestMethod]
        public void Ilheus_Cheeseburger()
        {
            this.cheeseburger = new PepperSauce(this.cheeseburger);

            Assert.AreEqual<string>("Bread, Hamburger, Cheese, Pepper Sauce", this.cheeseburger.Description);
            Assert.AreEqual<int>(320, this.cheeseburger.Calories());
        }

        [TestMethod]
        public void Ilheus_Cheeseburger_With_Onion_Rings_And_Corn()
        {
            this.cheeseburger = new PepperSauce(this.cheeseburger);
            this.cheeseburger = new OnionRings(this.cheeseburger);
            this.cheeseburger = new Corn(this.cheeseburger);

            Assert.AreEqual<string>("Bread, Hamburger, Cheese, Pepper Sauce, Onion Rings, Corn", this.cheeseburger.Description);
            Assert.AreEqual<int>(530, this.cheeseburger.Calories());
        }
    }
}

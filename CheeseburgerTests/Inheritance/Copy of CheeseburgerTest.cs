using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using CheeseburgerInheritance;

namespace CheeseburgerTests.Inheritance
{
    [TestClass]
    public class CheeseburgerTest
    {
        private MockRepository mocks;
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
            this.mocks = new MockRepository();
            this.cheeseburger = this.mocks.PartialMock<Cheeseburger>();
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
            //O método Calories de Cheeseburger não pode ser testado aqui, pois o Rhino Mocks sobrescreve a implementação virtual.
            //O método Calories deixou de ser virtual para pode ser testado com o Rhino Mocks.
        }
    }
}

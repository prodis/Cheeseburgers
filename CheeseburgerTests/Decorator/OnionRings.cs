using System;
using CheeseburgerDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace CheeseburgerTests.Decorator
{
    [TestClass]
    public class OnionRingsTest
    {
        private MockRepository mocks;
        private Sandwich sandwichMock;
        private OnionRings onionRings;
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
            this.sandwichMock = this.mocks.DynamicMock<Sandwich>();
        }

        [TestMethod]
        public void Description_Of_Cheeseburger_With_OnionRings()
        {
            Expect.Call(this.sandwichMock.Description).Return("Sandwich description");

            this.mocks.ReplayAll();
            
            this.onionRings = new OnionRings(this.sandwichMock);
            Assert.AreEqual<string>("Sandwich description, Onion Rings", this.onionRings.Description);

            this.mocks.VerifyAll();
        }

        [TestMethod]
        public void Calories_Of_Cheeseburger_With_OnionRings()
        {
            Expect.Call(this.sandwichMock.Calories()).Return(100);

            this.mocks.ReplayAll();

            this.onionRings = new OnionRings(this.sandwichMock);
            Assert.AreEqual<int>(240, this.onionRings.Calories());

            this.mocks.VerifyAll();
        }
    }
}

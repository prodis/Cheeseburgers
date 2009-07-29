using System;
using CheeseburgerDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace CheeseburgerTests.Decorator
{
    [TestClass]
    public class CornTest
    {
        private MockRepository mocks;
        private Sandwich sandwichMock;
        private Corn corn;
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
        public void Description_Of_Cheeseburger_With_Corn()
        {
            Expect.Call(this.sandwichMock.Description).Return("Sandwich description");

            this.mocks.ReplayAll();
            
            this.corn = new Corn(this.sandwichMock);
            Assert.AreEqual<string>("Sandwich description, Corn", this.corn.Description);

            this.mocks.VerifyAll();
        }

        [TestMethod]
        public void Calories_Of_Cheeseburger_With_Corn()
        {
            Expect.Call(this.sandwichMock.Calories()).Return(100);

            this.mocks.ReplayAll();

            this.corn = new Corn(this.sandwichMock);
            Assert.AreEqual<int>(170, this.corn.Calories());

            this.mocks.VerifyAll();
        }
    }
}

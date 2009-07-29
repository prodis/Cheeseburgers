using System;
using CheeseburgerComposition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace CheeseburgerTests.Composition
{
    [TestClass]
    public class CheeseburgerIlheusTest
    {
        private MockRepository mocks;
        private ICheeseburger cheeseburgerMock; 
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
            this.mocks = new MockRepository();
            this.cheeseburgerMock = this.mocks.DynamicMock<ICheeseburger>();
        }

        [TestMethod]
        public void Description_Of_Cheeseburger_Ilheus()
        {
            Expect.Call(this.cheeseburgerMock.Description).Return("Cheeseburger description");

            this.mocks.ReplayAll();
            this.cheeseburgerIlheus = new CheeseburgerIlheus(this.cheeseburgerMock);
            this.mocks.VerifyAll();

            Assert.AreEqual<string>("Cheeseburger description, Pepper Sauce", this.cheeseburgerIlheus.Description);
            //Com composição é possível assegurar a chamada da propriedade Description da implementação da interface ICheeseburger que foi passada no construtor de CheeseburgerIlheus.
        }

        [TestMethod]
        public void Calories_Of_Cheeseburger_Ilheus()
        {
            Expect.Call(this.cheeseburgerMock.Calories()).Return(100);
            
            this.mocks.ReplayAll();

            this.cheeseburgerIlheus = new CheeseburgerIlheus(this.cheeseburgerMock);
            Assert.AreEqual<int>(120, this.cheeseburgerIlheus.Calories());
            
            this.mocks.VerifyAll();
            //Aqui eu consigo assegurar, usando mocks, que o método Calories da implementação da interface ICheeseburger que foi passada no construtor de CheeseburgerIlheus foi chamado.
        }
    }
}

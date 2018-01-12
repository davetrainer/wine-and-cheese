using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WineAndCheese.Repositories.Tests
{
    [TestClass]
    public class WineRepositoryTests
    {

        #region Constants

        #endregion

        #region Constructors

        #endregion

        #region Events & Delegates

        #endregion

        #region Properties

        #endregion

        #region Methods

        [TestMethod]
        public void WhenICallGetyBIdThenTheCorrectWineIsReturned()
        {
            var id = 1;
            var wineRepository = new WineRepository();
            var wine = wineRepository.GetById(id);

            Assert.AreEqual(id, wine.Id);
        }

        #endregion
    }
}

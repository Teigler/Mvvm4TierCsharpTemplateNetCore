﻿using Mvvm4TierCsharpTemplate.DataAccess.API;
using NUnit.Framework;

namespace $safeprojectname$.DataAccess.API
{
    [TestFixture]
    public class DataAccessFactoryTest
    {
        [Test]
        public void CreateDataAccess_ReturnNewDataAccessCorrectType_Returned()
        {
            Assert.That(DataAccessFactory.CreateDataAccess(), Is.InstanceOf(typeof(IDataAccess)));
        }
    }
}
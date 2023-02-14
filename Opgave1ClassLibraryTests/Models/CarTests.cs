using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave1ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Opgave1ClassLibrary.Models.Tests
{
    [TestClass()]
    public class CarTests
    {
        private Car CarIdIsNegative = new() { Id = -10, Model = "FordsNewCar", Price = 10000, LicensePlate = "WG23580" };
        private Car CarModelIsNull = new() { Id = 1, Model = null, Price = 10000, LicensePlate = "WG23580" };
        private Car CarLicensePlateIsNull = new() { Id = 6, Model = "Ranger", Price = 10000, LicensePlate = null };
        private Car CarModelIsTooShort = new() { Id = 5, Model = "911", Price = 10000, LicensePlate = "WG23580" };
        private Car BadPriceCar = new() { Id = 3, Model = "Volvo", Price = -10, LicensePlate = "WG23580" };
        private Car BadLicensePlateCar = new() { Id = 4, Model = "Range rover", Price = 10000, LicensePlate = "WG235809202" };


        [TestMethod()]
        public void ValidateIdTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => CarIdIsNegative.ValidateID());
        }
        [TestMethod()]
        public void ValidateModelTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => CarModelIsTooShort.ValidateModel());
            Assert.ThrowsException<ArgumentNullException>(() => CarModelIsNull.ValidateModel());

        }
        [TestMethod()]
        public void ValidatePriceTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => BadPriceCar.ValidatePrice());
        }
        [TestMethod()]
        public void ValidateLicensePlateTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => BadLicensePlateCar.ValidateLicensePlate());
            Assert.ThrowsException<ArgumentNullException>(() => CarLicensePlateIsNull.ValidateLicensePlate());

        }

    }
}
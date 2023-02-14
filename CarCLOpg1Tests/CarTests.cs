using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarCLOpg1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCLOpg1.Tests
{
    [TestClass()]
    public class CarTests
    {
        Car car = new Car() { Id = 1, Model = "v700", Price = 35000, LicensePlate = "AF56724" };
        Car carLPShortButPasses = new Car() { Id = 1, Model = "v700", Price = 35000, LicensePlate = "AF" };

        Car carModelShort = new Car() { Id = 1, Model = "v70", Price = 35000, LicensePlate = "AF56724" };
        Car carPriceZero = new Car() { Id = 1, Model = "v700", Price = 0, LicensePlate = "AF56724" };
        Car carLPShort = new Car() { Id = 1, Model = "v700", Price = 35000, LicensePlate = "4" };
        Car carLPLong = new Car() { Id = 1, Model = "v700", Price = 35000, LicensePlate = "12345678" };

        [TestMethod()]
        public void ValidateModelTest()
        {
            car.ValidateModel();
            Assert.ThrowsException<ArgumentException>(() => carModelShort.ValidateModel());
        }

        [TestMethod()]
        public void ValidatePriceTest()
        {
            car.ValidatePrice();
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> carPriceZero.ValidatePrice());
        }

        [TestMethod()]
        public void ValidateLicensePlateTest()
        {
            car.ValidateLicensePlate();
            carLPShortButPasses.ValidateLicensePlate();
            Assert.ThrowsException<ArgumentException>(()=> carLPShort.ValidateLicensePlate());
            Assert.ThrowsException<ArgumentException>(() => carLPLong.ValidateLicensePlate());

        }

        [TestMethod()]
        public void ValidateTest()
        {
            car.ValidateModel();
            Assert.ThrowsException<ArgumentException>(() => carModelShort.ValidateModel());

            car.ValidatePrice();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carPriceZero.ValidatePrice());

            car.ValidateLicensePlate();
            carLPShortButPasses.ValidateLicensePlate();
            Assert.ThrowsException<ArgumentException>(() => carLPShort.ValidateLicensePlate());
            Assert.ThrowsException<ArgumentException>(() => carLPLong.ValidateLicensePlate());
        }
    }
}
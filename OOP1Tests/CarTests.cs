using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Tests
{
    [TestClass()]
    public class CarTests
    {

        private readonly Car car = new() {Id = 0, Model ="Fiat", Price =45000, Licenseplate ="CV45892" }; //Normal Bil
        private readonly Car carA = new() { Id = 0, Model = "Fiat", Price = -45000, Licenseplate = "CV45892" }; //Bil med negativ pris
        private readonly Car carB = new() { Id = 0, Model = "Fiat", Price = 45000, Licenseplate = "C" }; //Bil med kort nummerplade
        private readonly Car carC = new() { Id = 0, Model = "Fiat", Price = 45000, Licenseplate = "CV4589287" }; //Bil med for lCang nummerplade
        private readonly Car carD = new() { Id = 0, Model = null, Price = 45000, Licenseplate = "CV45892" }; //Bil med model = null
        private readonly Car carE = new() { Id = 0, Model = "", Price = 45000, Licenseplate = "CV45892" }; //Bil uden model

        [TestMethod()]
        public void ValidatePriceTest()
        {
            car.ValidatePrice();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carA.ValidatePrice());
        }

        [TestMethod()]
        public void ValidateModelTest()
        {
            car.ValidateModel();
            Assert.ThrowsException<ArgumentNullException>(() => carD.ValidateModel());
            Assert.ThrowsException<ArgumentException>(() => carE.ValidateModel());  
        }

        [TestMethod()]
        public void ValidateLicensePlateTest()
        {
            car.ValidateLicensePlate();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carB.ValidateLicensePlate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carC.ValidateLicensePlate());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            car.Validate();
        }
    }
}
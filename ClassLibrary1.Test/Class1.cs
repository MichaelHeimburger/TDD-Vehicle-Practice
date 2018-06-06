using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test
{
    [TestFixture]
    class VehicleTest
    {
        [Test]
        public void TestForCreationOfNewClass() // tests ctor and class creation
        {
            var vehicle = new Vehicle();
            var result = vehicle;
            Assert.That(result, Is.EqualTo(vehicle));
        }
        [Test]
        public void TestForCreationOfSpeedProperty() // 1
        {
            var vehicle = new Vehicle();
            vehicle.Speed = 1;
            Assert.That(1, Is.EqualTo(vehicle.Speed));
        }
        [Test]
        public void TestForCreationOfModelNameProperty() // 2
        {
            var vehicle = new Vehicle();
            vehicle.ModelName = "JAMES";
            Assert.That("JAMES", Is.EqualTo(vehicle.ModelName));
        }
        [Test]
        public void TestForCreationOfModelTireNumbersProperty() // 3 - 1 tests  creation fo fields and property
        {
            var vehicle = new Vehicle();
            vehicle.Tires = 5;
            Assert.That(5, Is.EqualTo(vehicle.Tires));
        }
        [Test]
        public void TestForCreationOfReturningMethod() // tests for result of maxspeed
        {
            var vehicle = new Vehicle();
            vehicle.Tires = 5;
            vehicle.Speed = 10;
            Assert.That(vehicle.Tires*vehicle.Speed, Is.EqualTo(vehicle.MaxSpeed()));
        }
        [Test]
        public void TestForVirtualMethod() //tests for result of virtual method
        {
            var vehicle = new Vehicle();
            vehicle.Tires = 5;
            vehicle.Speed = 10;
            Assert.That(vehicle.Speed-vehicle.Tires, Is.EqualTo(vehicle.MinSpeed()));

        }
        [Test]
        public void TestCreationOfBoatClass() //tests for creation of boat class and constructor
        {
            var boat = new Boat();
            var result = boat;
            Assert.That(result, Is.EqualTo(boat));

        }
        [Test]
        public void TestForInheritance() //tests for inheritance in boat and vehicle by setting a property
        {
            var boat = new Boat();
            boat.Speed = 50;
            Assert.That(50, Is.EqualTo(boat.Speed));
        }
        [Test]
        public void TestOfOverrideClassGivingSeperateResultThanVirtual() //tests for return of overide class being differnt than virtual
        {
            var boat = new Boat();
            var vehicle = new Vehicle();
            vehicle.Speed = 50;
            boat.Speed = 50;
            vehicle.Tires = 5;
            boat.Tires = 5;
            Assert.That(vehicle.MinSpeed, Is.Not.EqualTo(boat.MinSpeed()));
        }

    }
}

using NUnit.Framework;
using ClassesApp;
using SafariPark;

namespace AirplaneTest
{
    public class Tests
    {
        [TestCase(200, 1000, 1000)]
        [TestCase(200, -400, 0)]
        [TestCase(200, 50000, 27000)]
        public void AltitudeTestsFor200CapacityAirPlane(int capacity, int distance, int expected)
        {
            Airplane a = new Airplane(capacity);
            a.Ascend(distance);
            var result = a.Move();
            Assert.AreEqual($"Moving along at an altitude of {expected} metres.", result);
        }
        [Test]
        public void WhenAnAirplaneWith200Capacity100SpeedAirlineJetsRUsAndNumPassengers150IsMoved3TimesItsPositionIs300()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(300);
            var result = a.Move(3);
            Assert.AreEqual(300, a.Position);
            Assert.AreEqual("Moving along 3 times at an altitude of 300 metres.", result);
        }

        [Test]
        public void WhenAnAirplaneWith200Capacity100SpeedAirlineJetsRUsAndNumPassengers150IsMoved3TimesAndAscends500ItsPositionIs300AndItsAltitudeIs500()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            a.Move(3);
            var result = a.ToString();
            Assert.AreEqual(300, a.Position);
            Assert.AreEqual("Thank you for flying JetsRUs: ClassesApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 300 altitude: 500.", result);
        }

        [Test]
        public void WhenAnAirplaneWith200Capacity100SpeedAirlineJetsRUsAndNumPassengers150Ascends500AndDescends200ItsAltitudeIs300()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            a.Descend(200);
            var result = a.Move();
            Assert.AreEqual("Moving along at an altitude of 300 metres.", result);
        }

        [Test]
        public void Testname()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            a.Move(5);
            a.Descend(200);
            var result = a.ToString();
            Assert.AreEqual("Thank you for flying JetsRUs: ClassesApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 500 altitude: 300.", result) ;
        }

        [TestCase(5, -1, 0)]
        [TestCase(5, 10, 5)]
        [TestCase(5, 4, 4)]
        public void NumPassengersVsCapacityTest(int capacity, int numPassengers, int expected)
        {
            Airplane a = new Airplane(capacity);
            a.NumPassengers = numPassengers;
            var result = a.NumPassengers;
            Assert.AreEqual(expected, result);
        }
    }
}
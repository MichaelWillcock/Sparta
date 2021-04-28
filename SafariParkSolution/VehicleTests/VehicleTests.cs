using NUnit.Framework;
using SafariPark;

namespace CarHomeworkTest
{
    public class Tests
    {
        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }
        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }
        [TestCase(5, -1, 0)]
        [TestCase(5, 10, 5)]
        [TestCase(5, 4, 4)]
        public void NumPassengersVsCapacityTest(int capacity, int numPassengers, int expected)
        {
            Vehicle v = new Vehicle(capacity);
            v.NumPassengers = numPassengers;
            var result = v.NumPassengers;
            Assert.AreEqual(expected, result);
        }
    }
}
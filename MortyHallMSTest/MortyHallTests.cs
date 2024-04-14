using System.Runtime.CompilerServices;

namespace MontyCarloMortyHall;

[TestClass]
public class MortyHallSimulationTests
{
    [TestMethod]
    public void CheckSimulationCorrectSize()
    {
        var montyHall = new MortyHallTestCreator();
        var randomMontyHallTest = montyHall.CreateRandomTest();

        Assert.AreEqual(3, randomMontyHallTest.Length);
    }

    [TestMethod]
    public void CheckCorrectAmountOfGoatsAndCar()
    {
        var montyHall = new MortyHallTestCreator();

        for (int i = 0; i < 10; i++)
        {
            var randomMontyHallTest = montyHall.CreateRandomTest();

            int goatCount = 0, carCount = 0;
            foreach (var goatCar in randomMontyHallTest)
            {
                if (goatCar == DoorOptions.Goat)
                    goatCount++;

                if (goatCar == DoorOptions.Car)
                    carCount++;
            }

            Assert.AreEqual(2, goatCount);
            Assert.AreEqual(1, carCount);
        }
    }

    [TestMethod]
    public void RunSimulationTest()
    {
        var simulator = new MontyCarloMortyHallSimulator();

        simulator.RunSimulation(100);
    }
}
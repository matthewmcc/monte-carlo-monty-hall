using System.Runtime.CompilerServices;

namespace MonteCarloMontyHall;

[TestClass]
public class MonteHallSimulationTests
{
    [TestMethod]
    public void CheckSimulationCorrectSize()
    {
        var monteHall = new MontyHallTestCreator();
        var randomMonteHallTest = monteHall.CreateRandomTest();

        Assert.AreEqual(3, randomMonteHallTest.Length);
    }

    [TestMethod]
    public void CheckCorrectAmountOfGoatsAndCar()
    {
        var monteHall = new MontyHallTestCreator();

        for (int i = 0; i < 10; i++)
        {
            var randomMonteHallTest = monteHall.CreateRandomTest();

            int goatCount = 0, carCount = 0;
            foreach (var goatCar in randomMonteHallTest)
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
        var simulator = new MonteCarloMontyHallSimulator();

        simulator.RunSimulation(100);
    }
}
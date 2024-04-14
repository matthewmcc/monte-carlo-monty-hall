namespace MontyCarloMortyHall;

public class MontyCarloMortyHallSimulator  {
    
    private const int AMOUNT_OF_DOORS = 3;

    private MortyHallTestCreator testCreator = new MortyHallTestCreator();
    private Random doorSelectorRandom = new Random();

    private bool SimulateSwitchTest()
    {
        var randomTest = testCreator.CreateRandomTest();

        var selectedDoorIndex = SelectRandomDoor();

        int doorShownIndex = 0;
        if (randomTest[selectedDoorIndex] == DoorOptions.Goat)
        {
            for (int i = 0; i < AMOUNT_OF_DOORS; i++)
            {
                if (i == selectedDoorIndex)
                    continue;

                if (randomTest[i] == DoorOptions.Goat)
                {
                    doorShownIndex = i;
                    break;
                }
            }
        }
        else
        {
            var doorsToShownPossibleIndexes = new List<int> { 0, 1, 2, };

            doorsToShownPossibleIndexes.Remove(selectedDoorIndex);
            doorShownIndex = doorsToShownPossibleIndexes[doorSelectorRandom.Next(2)];
        }

        // Switching to final door
        var allDoorIndexes = new List<int> { 0, 1, 2, };
        allDoorIndexes.Remove(selectedDoorIndex);
        allDoorIndexes.Remove(doorShownIndex);

        var switchedToDoor = allDoorIndexes[0];

        return randomTest[switchedToDoor] == DoorOptions.Car;
    }

    private bool SimulateNoSwitchTest()
    {
        var randomTest = testCreator.CreateRandomTest();

        var selectedDoorIndex = SelectRandomDoor();

        return randomTest[selectedDoorIndex] == DoorOptions.Car;
    }

    public void RunSimulation(int simulationCount)
    {
        int foundCarCount = 0;

        for (int i = 0; i < simulationCount; i++)
        {
            if (SimulateSwitchTest())
                foundCarCount++;
        }

        Console.WriteLine("Simulation switching after location of goat is shown");
        Console.WriteLine($"Car found count: {foundCarCount}, Got the Goat: {simulationCount - foundCarCount}");
        double carFoundProbability = ((double) foundCarCount / (double) simulationCount) * 100;
        Console.WriteLine($"Probability of getting the car: {carFoundProbability}%");


        foundCarCount = 0;
        for (int i = 0; i < simulationCount; i++)
        {
            if (SimulateNoSwitchTest())
                foundCarCount++;
        }

        Console.WriteLine("");
        Console.WriteLine("Simulation staying with first choice");
        Console.WriteLine($"Car found count: {foundCarCount}, Got the Goat: {simulationCount - foundCarCount}");
        carFoundProbability = ((double) foundCarCount / (double) simulationCount) * 100;
        Console.WriteLine($"Probability of getting the car: {carFoundProbability}%");
    }


    private int SelectRandomDoor() 
    {
        return doorSelectorRandom.Next(AMOUNT_OF_DOORS);
    }
}
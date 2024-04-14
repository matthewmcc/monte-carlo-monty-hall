namespace MontyCarloMortyHall;

public enum DoorOptions
{
    Goat,
    Car
};

public class MortyHallTestCreator {
    private Random GoatCarRandom = new Random();

    public DoorOptions[] CreateRandomTest()
    {
        DoorOptions[] randomTest = new DoorOptions[3];

        randomTest[GoatCarRandom.Next(3)] = DoorOptions.Car;

        return randomTest;
    }
}
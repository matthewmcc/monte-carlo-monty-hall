// See https://aka.ms/new-console-template for more information
using System;

namespace MontyCarloMortyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            MontyCarloMortyHallSimulator mortyHallSimulator = new MontyCarloMortyHallSimulator();
            mortyHallSimulator.RunSimulation(1000);
        }
    }
}
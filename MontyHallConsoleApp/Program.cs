// See https://aka.ms/new-console-template for more information
using System;

namespace MonteCarloMontyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            MonteCarloMontyHallSimulator monteHallSimulator = new MonteCarloMontyHallSimulator();
            monteHallSimulator.RunSimulation(1000);
        }
    }
}
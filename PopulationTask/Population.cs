using System;

namespace PopulationTask
{
    public static class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (currentPopulation < 0 || currentPopulation == 0)
            {
                throw new ArgumentException("Parameter is less or equals zero", nameof(currentPopulation));
            }

            if (currentPopulation < initialPopulation)
            {
                throw new ArgumentException("Parameter is less than initialPopulation", nameof(currentPopulation));
            }

            if (initialPopulation < 0 || initialPopulation == 0)
            {
                throw new ArgumentException("Parameter is less or equals zero", nameof(initialPopulation));
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent));
            }

            if (visitors < 0)
            {
                throw new ArgumentException("Parameter is less zero", nameof(visitors));
            }

            var count = 1;
            double percentPopulation = initialPopulation * percent / 100;
            
            double newPopulation = initialPopulation + percentPopulation + visitors;
            while (newPopulation < currentPopulation)
            {
                percentPopulation = newPopulation * percent / 100;
                newPopulation += percentPopulation + visitors;
                count++;
            }

            return count;
        }
    }
}

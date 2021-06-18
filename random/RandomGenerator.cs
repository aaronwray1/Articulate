using System;
using System.Diagnostics.CodeAnalysis;

namespace random
{
    [ExcludeFromCodeCoverage]

    public class RandomGenerator : IRandomGenerator
    {
        public virtual int Generate(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}

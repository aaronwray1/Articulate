using System;

namespace random
{
    public interface IRandomGenerator
    {
        int Generate(int min, int max);
    }
}

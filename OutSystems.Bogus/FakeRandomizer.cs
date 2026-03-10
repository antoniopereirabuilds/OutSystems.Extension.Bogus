namespace OutSystems.Bogus
{
    /// <summary>
    /// Implementation of IFakeRandomizer. Provides randomizer utility actions.
    /// </summary>
    public class FakeRandomizer : IFakeRandomizer
    {
        public string FakeGuid(int seed = 0)
        {
            var randomizer = FakerHelper.CreateRandomizer(seed);
            return randomizer.Guid().ToString();
        }

        public int FakeNumber(int min = 0, int max = 100, int seed = 0)
        {
            var randomizer = FakerHelper.CreateRandomizer(seed);
            return randomizer.Number(min, max);
        }

        public decimal FakeDecimal(decimal min = 0, decimal max = 100, int seed = 0)
        {
            var randomizer = FakerHelper.CreateRandomizer(seed);
            return randomizer.Decimal(min, max);
        }

        public bool FakeBoolean(decimal weight = 0.5m, int seed = 0)
        {
            var randomizer = FakerHelper.CreateRandomizer(seed);
            return randomizer.Bool((float)weight);
        }

        public string FakeHash(int length = 40, int seed = 0)
        {
            FakerHelper.ValidateLength(length, nameof(length));
            var randomizer = FakerHelper.CreateRandomizer(seed);
            return randomizer.Hash(length);
        }

        public string FakeAlphaNumeric(int length = 10, int seed = 0)
        {
            FakerHelper.ValidateLength(length, nameof(length));
            var randomizer = FakerHelper.CreateRandomizer(seed);
            return randomizer.AlphaNumeric(length);
        }
    }
}

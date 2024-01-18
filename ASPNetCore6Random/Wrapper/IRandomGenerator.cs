namespace ASPNetCore6Random.Wrapper
{
    public interface IRandomGenerator
    {
        int Next();
        int Next(int maxValue);
        int Next(int minValue, int maxValue);
        double NextDouble();
    }
}

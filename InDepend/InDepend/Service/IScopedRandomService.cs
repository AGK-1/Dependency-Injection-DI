public interface IScopedRandomService
{
    int GetRandomNumber();
}

public class ScopedRandomService : IScopedRandomService
{
    private readonly int _randomNumber;

    public ScopedRandomService()
    {
        _randomNumber = new Random().Next(1, 1000);
    }

    public int GetRandomNumber()
    {
        return _randomNumber;
    }
}
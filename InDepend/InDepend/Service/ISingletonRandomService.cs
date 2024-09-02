public interface ISingletonRandomService
{
    int GetRandomNumber();
}

public class SingletonRandomService : ISingletonRandomService
{
    private readonly int _randomNumber;

    public SingletonRandomService()
    {
        _randomNumber = new Random().Next(1, 1000);
    }

    public int GetRandomNumber()
    {
        return _randomNumber;
    }
}
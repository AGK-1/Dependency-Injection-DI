public interface ITransientRandomService
{
    int GetRandomNumber();
}

public class TransientRandomService : ITransientRandomService
{
    private readonly int _randomNumber;

    public TransientRandomService()
    {
        _randomNumber = new Random().Next(1, 1000);
    }

    public int GetRandomNumber()
    {
        return _randomNumber;
    }
}
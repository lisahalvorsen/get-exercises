namespace Exercise341B;

public interface ICommand
{
    char Character { get; }
    
    void Run();
    
}
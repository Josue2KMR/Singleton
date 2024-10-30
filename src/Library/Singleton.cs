namespace Library;

public abstract class Singleton<T> where T : new()
{

    private static T? _instance = new();
    
    private Singleton() { }
        
    public static T Instance
    {
        return _instance.value;
    }
}
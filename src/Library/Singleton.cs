namespace Library;

public abstract class Singleton<T> where T : new()
{

    private static T instance;
    
    private Singleton() { }
        
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
            }

            return instance;
        }
    }
}
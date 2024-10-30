namespace Library;

public abstract class Singleton<T> where T : new()
{

    private static T instance;
        
    public static T Instance // devuelve el tipo T que se envió
    {
        get
        {
            if (instance == null)
            {
                instance = new T(); // Se crea una instancia de tipo T si no existe la instancia
            }

            return instance;
        }
    }
}
namespace Singleton;
internal class SingletonClass
{
    private static SingletonClass? _singletonClass;
    private static readonly object Obj = new();

    private SingletonClass()
    {
    }

    public void Print()
    {
        Console.WriteLine("This is Singleton Class");
    }

    public static SingletonClass GetSingletonClass()
    {
        lock (Obj)
        {
            if (_singletonClass != null)
            {
                return _singletonClass;
            }

            _singletonClass = new SingletonClass();

            return _singletonClass;
        }
    }
}

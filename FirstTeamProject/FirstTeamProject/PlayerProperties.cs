public class PlayerProperties<T> : IObserver
{
    private T _value;
    public T Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void Publish()
    {

    }
}
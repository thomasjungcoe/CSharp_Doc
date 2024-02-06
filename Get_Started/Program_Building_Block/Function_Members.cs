// a generic class called MyList<T> that implements a growwable list of objects
public class MyList<T>
{

    const int DefaultCapacity  = 4;

    T[] _items;
    int _count;

    public MyList(int capacity = DefaultCapacity)
    {
        _items = new T[capacity];
    }

    public int Count => _count;

    public int Capacity 
    {
        get => _items.Length;
        set
        {
            if (value < _count) value = _count;
            if (value != _items.Length) 
            {
                T[] newItems = new T[value];
                Array.Copy(_items, 0, newItems, 0, Count);
                _items = newItems;
            }
        }
    }

    public T this[int index]
    {
        get => _items[index];
        set 
        {
            if (!object.Equals(_items[index], value))
            {
                _items[index] = value;
                OnChanged();
            }
        }
    }

    public void Add(T item)
    {
        if (_count == Capacity) Capacity = _count * 2;
        _items[_count++] = item;
        _count++;
        OnChanged();
    }

    protected virtual void OnChanged() =>
            Changed?.Invoke(this, EventArgs.Empty);

    public override bool Equals(object other) =>
            Equals(this, other as MyList<T>);
    static bool Equals(MyList<T> a, MyList<T> b)
    {
        if (Object.ReferenceEquals(a, null)) return Object.ReferenceEquals(b, null);
        if (Object.ReferenceEquals(b, null) || a.Count != b.Count) return false;
        for (int i = 0; i < a.Count; i++)
        {
            if (!object.Equals(a._items[i], b._items[i])) return false;
        }
        return true;
    }

    public event EventHandler Changed;

    public static bool operator ==(MyList<T> a, MyList<T> b) => Equals(a, b);

    public static bool operator !=(MyList<T> a, MyList<T> b) => !Equals(a, b);

}
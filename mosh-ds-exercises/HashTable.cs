namespace mosh_ds_exercises;

public class HashTable
{
    private class Entry
    {
        public readonly int Key;
        public readonly string Value;

        public Entry(int key, string value)
        {
            Key = key;
            Value = value;
        }
        
    }
    private readonly int _size;
    private LinkedList<Entry>[] _table;
    public HashTable(int size)
    {
        _size = size;
        _table = new LinkedList<Entry>[size];
    }

    private int GetHashedKey(int key)
    {
        return key % _size;
    }

    public void Put(int key, string value)
    {
        var hashedKey = GetHashedKey(key);
        var entry = new Entry(key, value);
        if (_table[hashedKey] == null)
        {
            var list = new LinkedList<Entry>();
            list.AddLast(entry);
            _table[hashedKey] = list;
        }
        else
        {
            _table[hashedKey].AddLast(entry);
        }
    }

    public string Get(int key)
    {
        if (!ContainsKey(key)) throw new Exception($"{key} not found");

        var hashedKey = GetHashedKey(key);
        var curr = _table[hashedKey].First;
        
        while (curr != null)
        {
            if (curr.Value.Key == key) return curr.Value.Value;
            curr = curr.Next;
        }
        return null;
    }

    public void Remove(int key)
    {
        if (!ContainsKey(key)) throw new Exception($"{key} not found");
        var hashedKey = GetHashedKey(key);
        _table[hashedKey] = null;
    }

    public bool ContainsKey(int key)
    {
        var hashedKey = GetHashedKey(key);
        return _table[hashedKey] != null;
    }
}
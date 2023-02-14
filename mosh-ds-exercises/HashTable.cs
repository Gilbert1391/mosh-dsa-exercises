namespace mosh_ds_exercises;

public class HashTable
{
    private class Entry
    {
        public int Key;
        public string Value;

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
        return Math.Abs(key) % _size;
    }

    public void Put(int key, string value)
    {
        // []
        // [[{key: 3, value: 'Peter'}], [{key: 4, value: 'Flor'}, {key: 1, value: 'John'} ], [{key: 2, value: 'Dean'}]]

        var hashedKey = GetHashedKey(key);
        var entry = new Entry(key, value);
        if (_table[hashedKey] == null)
        {
            var list = new LinkedList<Entry>();
            list.AddFirst(entry);
            _table[hashedKey] = list;
        }
        else
        {
            var curr = _table[hashedKey].First;
            var found = false;
            while (curr != null)
            {
                found = curr.Value.Key == key;
                if (found)
                {
                    curr.Value.Value = value;
                    break;
                }
                curr = curr.Next;
            }
            
            if (!found) _table[hashedKey].AddFirst(entry);
        }
    }

    public string Get(int key)
    {
        string result = null;
        if (!ContainsKey(key)) return result;

        var hashedKey = GetHashedKey(key);
        var curr = _table[hashedKey].First;
        
        while (curr != null)
        {
            if (curr.Value.Key == key) result = curr.Value.Value;
            curr = curr.Next;
        }
        return result;
    }

    public void Remove(int key) // key = 4 || 1 -> 1
    {
        // [[{key: 3, value: 'Peter'}], [{key: 4, value: 'Flor'}, {key: 1, value: 'John'} ], [{key: 2, value: 'Dean'}]]
        //                                                              c
        if (!ContainsKey(key)) throw new Exception($"{key} not found");

        var hashedKey = GetHashedKey(key);
        var curr = _table[hashedKey].First;
        while (curr != null)
        {
            if (curr.Value.Key == key)
            {
                _table[hashedKey].Remove(curr);
                return;
            }
            curr = curr.Next;
        }
    }

    public bool ContainsKey(int key) // key = 4 || 1 -> 1
    {
        var hashedKey = GetHashedKey(key);
        var curr = _table[hashedKey].First;
        while (curr != null)
        {
            if (curr.Value.Key == key) return true;
            curr = curr.Next;
        }
        return false;
    }
}
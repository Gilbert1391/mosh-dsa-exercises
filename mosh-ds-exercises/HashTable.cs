namespace mosh_ds_exercises;

public class HashTable
{
   
    public HashTable(int size)
    {
        _size = size;
        _table = new LinkedList<Entry>[size];
    }
    
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

    private int GetHashedKey(int key)
    {
        return Math.Abs(key) % _size;
    }

    public void Put(int key, string value)
    {
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

    public void Remove(int key) 
    {
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

    public bool ContainsKey(int key)
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

    public static int GetMostFrequent(int[] array)
    {
        if (array.Length == 0) throw new Exception();
        
       var table = new Dictionary<int, int>();
        foreach (var t in array)
        {
            if (table.ContainsKey(t)) ++table[t];
            else table.Add(t, 1);
        }

        var max = 0;
        foreach (var entry in table)
        {
            if (entry.Value > max) max = entry.Value;
        }
        return max;
    }

    public static int CountUniquePairsWithDiff(int[] array, int k)
    {
        var set = new HashSet<int>();
        for (int i = 0; i < array.Length; i++)
        {
            set.Add(array[i]);
        }

        var pairCount = 0;
        foreach (var i in set)
        {
            foreach (var j in set)
            {
                if (i - j == k) pairCount++;
            }
        }

        return pairCount;
    }

    public static int[] TwoSum(int[] array, int target)
    {
        var items = new Dictionary<int, int>();
        for (int i = 0; i < array.Length; i++)
        {
            items.Add(array[i], i);
        }
        foreach (var i in items)
        {
            foreach (var j in items)
            {
                if (i.Key + j.Key == target) return new[] { i.Value, j.Value };
            }
        }
        return System.Array.Empty<int>();
    }
}
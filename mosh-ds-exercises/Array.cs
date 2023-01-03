namespace mosh_ds_exercises;

public class Array
{
    private int[] _array;
    private int _count;
    public Array(int length)
    {
        _array = new int[length];
    }

    public void Insert(int item)
    {
        if (_array.Length == _count)
        {
            var items = new int[_count + 1];
            for (int i = 0; i < _count; i++)
            {
                items[i] = _array[i];
            }
            items[_count] = item;
            _array = items;
        }
        else
        {
            _array[_count] = item;
        }
        _count++;
    }

    public void RemoveAtIndex(int index)
    {
        if (index < 0 || index >= _count) throw new ArgumentException();
        
        _count--;
        var items = new int[_count];
        if (index == _count)
        {
            for (int i = 0; i < _count; i++)
            {
                items[i] = _array[i];
            }
            _array = items;
        }
        else
        {
            for (int i = 0; i < index; i++)
            {
                items[i] = _array[i];
            }
            for (int i = index; i < _count; i++)
            {
                items[i] = _array[i + 1];
            }
            _array = items;
        }
    }

    public int IndexOf(int item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_array[i] == item) return i;
        }

        return -1;
    }

    public int Max()
    {
        int temp;
        var max = _array[0];
        for (int i = 0; i < _count; i++)
        {
            temp = _array[i];
            if (temp > max) max = temp;
        }
        return max;
    }

    public int[] Intersect(int[] items)
    {
        if (items.Length == 0) return new int[0];
       
        var duplicates = new int[_count];
        var count = 0;
        var sortedItems = items.Distinct().OrderBy(e => e).ToArray();
        for (int i = 0; i < sortedItems.Length; i++)
        {
            var foundIdx = IndexOf(sortedItems[i]);
            if (foundIdx > -1)
            {
                duplicates[i] = sortedItems[i];
                count++;
            }
        }

        var result = new int[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = duplicates[i];
        }
        return result;
    }

    public void Reverse()
    {
        var items = new int[_count];
        for (int i = _count; i > 0; i--)
        {
            items[_count - i] = _array[i-1];
        }
        _array = items;
    }

    public void InsertAt(int item, int index)
    {
        if (index < 0) throw new ArgumentException();

        // copy arr
        var result = new int[_count + 1];
        for (var i = 0; i < _count; i++)
        {
            result[i] = _array[i];
        }
        
        var isLastIdx = index >= _count;
        if (isLastIdx)
        {
            result[_count] = item;
            _array = result;
        }
        else
        {
            // insert item at index
            result[index] = item;
            // start insert from idx till end
            for (int i = index; i < _count; i++)
            {
                result[i + 1] = _array[i];
            }
            _array = result; 
        }
        _count++;
    }
    
    public void PrintItems()
    {
        foreach (var i in _array)
        {
            Console.WriteLine(i);
        }
    }
}
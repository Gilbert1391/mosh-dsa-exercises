// See https://aka.ms/new-console-template for more information

using Array = mosh_ds_exercises.Array;
using LinkedList = mosh_ds_exercises.LinkedList;

var list = new LinkedList();

for (var i = 3; i <= 5; i++)
{
    list.AddLast(i);
}
list.AddFirst(2);
list.AddFirst(1);

list.PrintItems();
Console.WriteLine(list.Contains(1));

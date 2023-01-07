// See https://aka.ms/new-console-template for more information

using Array = mosh_ds_exercises.Array;
using LinkedList = mosh_ds_exercises.LinkedList;

var list = new LinkedList();

for (var i = 1; i <= 3; i++)
{
    list.AddLast(i);
}

Console.WriteLine(list.Size());
list.RemoveFirst();
list.RemoveFirst();
list.RemoveFirst();
Console.WriteLine(list.Size());

//list.PrintItems();



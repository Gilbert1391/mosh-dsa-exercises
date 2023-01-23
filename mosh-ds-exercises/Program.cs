// See https://aka.ms/new-console-template for more information

using Array = mosh_ds_exercises.Array;
using LinkedList = mosh_ds_exercises.LinkedList;

var list = new LinkedList();

for (var i = 1; i <= 6; i++)
{
    list.AddLast(i);
    //list.AddLast(i + (9*i));
}

list.PrintItems();
Console.WriteLine("======");
list.PrintListMedian();


// See https://aka.ms/new-console-template for more information

using mosh_ds_exercises;
using Array = mosh_ds_exercises.Array;
using LinkedList = mosh_ds_exercises.LinkedList;
using Stack = mosh_ds_exercises.Stack;
//using Queue = mosh_ds_exercises.ArrayQueue;
// using StackQueue = mosh_ds_exercises.StackQueue;
//using priorityQueue = mosh_ds_exercises.ArrayPriorityQueue;
///using Queue = mosh_ds_exercises.LinkedListQueue;
using HashTable = mosh_ds_exercises.HashTable;

var hashtable = new HashTable(3);

hashtable.Put(1, "John");
hashtable.Put(2, "Dean");
hashtable.Put(3, "Peter");
hashtable.Put(4, "Mary");
hashtable.Put(4, "Flor");

Console.WriteLine(hashtable.ContainsKey(1));
var key = 1;
hashtable.Remove(key);
hashtable.Remove(4);
hashtable.Put(4, "Luis");

var val = hashtable.Get(4);


Console.WriteLine(val);
// Console.WriteLine(hashtable.ContainsKey(key));

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

var array = new[] {2, 7, 11, 15};
var result = HashTable.TwoSum(array, 9);


Console.WriteLine(result);

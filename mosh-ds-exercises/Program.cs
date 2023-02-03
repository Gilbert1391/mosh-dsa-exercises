// See https://aka.ms/new-console-template for more information

using mosh_ds_exercises;
using Array = mosh_ds_exercises.Array;
using LinkedList = mosh_ds_exercises.LinkedList;
using Stack = mosh_ds_exercises.Stack;
//using Queue = mosh_ds_exercises.ArrayQueue;
// using StackQueue = mosh_ds_exercises.StackQueue;
//using priorityQueue = mosh_ds_exercises.ArrayPriorityQueue;
using Queue = mosh_ds_exercises.LinkedListQueue;


var queue = new Queue(3);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);


Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
queue.Enqueue(4);
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());

// See https://aka.ms/new-console-template for more information

using mosh_ds_exercises;
using Array = mosh_ds_exercises.Array;
using LinkedList = mosh_ds_exercises.LinkedList;
using Stack = mosh_ds_exercises.Stack;
// using Queue = mosh_ds_exercises.ArrayQueue;
// using StackQueue = mosh_ds_exercises.StackQueue;
using priorityQueue = mosh_ds_exercises.ArrayPriorityQueue;



var queue = new priorityQueue(3);
queue.Enqueue(6);
queue.Enqueue(4);
queue.Enqueue(3);
// 3, 4, 6
Console.WriteLine(queue.DeQueue());
Console.WriteLine(queue.DeQueue());
Console.WriteLine(queue.DeQueue());
queue.Enqueue(2);
queue.Enqueue(1);
Console.WriteLine(queue.Peek());
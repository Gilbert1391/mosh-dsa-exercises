// See https://aka.ms/new-console-template for more information

using mosh_ds_exercises;
using Array = mosh_ds_exercises.Array;
using LinkedList = mosh_ds_exercises.LinkedList;
using Stack = mosh_ds_exercises.Stack;
using Queue = mosh_ds_exercises.ArrayQueue;
using StackQueue = mosh_ds_exercises.StackQueue;


var queue = new StackQueue(3);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);


queue.DeQueue(); // 1
queue.Enqueue(4);
queue.DeQueue(); // 2
queue.DeQueue(); // 3
queue.Enqueue(5);
queue.DeQueue(); // 4
Console.WriteLine(queue.DeQueue());
// queue.DeQueue();



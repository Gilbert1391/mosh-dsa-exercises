// See https://aka.ms/new-console-template for more information

using mosh_ds_exercises;
using Array = mosh_ds_exercises.Array;
using LinkedList = mosh_ds_exercises.LinkedList;
using Stack = mosh_ds_exercises.Stack;

var stack = new Stack();
stack.Push(10);
stack.Push(20);
stack.Push(30);

stack.Pop();
stack.Pop();

Console.WriteLine(stack.Peek());
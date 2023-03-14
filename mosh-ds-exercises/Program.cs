// See https://aka.ms/new-console-template for more information

using mosh_ds_exercises;
using Array = mosh_ds_exercises.Array;
using LinkedList = mosh_ds_exercises.LinkedList;
using Stack = mosh_ds_exercises.Stack;
//using Queue = mosh_ds_exercises.ArrayQueue;
// using StackQueue = mosh_ds_exercises.StackQueue;
//using priorityQueue = mosh_ds_exercises.ArrayPriorityQueue;
///using Queue = mosh_ds_exercises.LinkedListQueue;
// using HashTable = mosh_ds_exercises.HashTable;
using BinaryTree = mosh_ds_exercises.BinarySearchTree;

var tree = new BinarySearchTree();
// tree.Insert(10);
// tree.Insert(5);
// tree.Insert(15);
// tree.Insert(3);
// tree.Insert(13);
// tree.Insert(7);
// tree.Insert(17);
tree.Insert(7);
tree.Insert(4);
tree.Insert(9);
tree.Insert(1);
tree.Insert(8);
tree.Insert(6);
tree.Insert(10);

var result = tree.Height();
Console.WriteLine(result);

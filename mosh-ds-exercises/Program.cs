// See https://aka.ms/new-console-template for more information

using mosh_ds_exercises;
using Array = mosh_ds_exercises.Array;
using LinkedList = mosh_ds_exercises.LinkedList;

var str = "(([1] + <2>))[a]";
var result = StringHelper.IsExpressionBalanced(str);
Console.WriteLine(result);
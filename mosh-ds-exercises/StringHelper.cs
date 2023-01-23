namespace mosh_ds_exercises;

public class StringHelper
{
     private class PairBrackets
     {
          public readonly char OpeningChar;
          public readonly char ClosingChar;
          public PairBrackets(char openingChar, char closingChar)
          {
               ClosingChar = closingChar;
               OpeningChar = openingChar;
          }
     }
     public static string Reverse(string input)
     {
          if (string.IsNullOrEmpty(input)) return "";
          
          var stack = new Stack<char>();
          foreach (var c in input)
          {
               stack.Push(c);
          }

          var result = "";
          for (int i = 0; i < input.Length; i++)
          {
               result += stack.Pop();
          }
          return result;
     }

     public static bool IsExpressionBalanced(string input)
     {
          if (string.IsNullOrEmpty(input)) return false;
          
          var c1 = new PairBrackets('(', ')');
          var c2 = new PairBrackets('[', ']');
          var c3 = new PairBrackets('{', '}');
          var c4 = new PairBrackets('<', '>');
          var brackets = new List<PairBrackets> { c1, c2, c3, c4 };
          
          var openingCharsStack = new Stack<char>();
          foreach (var c in input)
          {
               if (brackets.Select(e => e.OpeningChar).Contains(c)) openingCharsStack.Push(c);
               
               if (brackets.Select(e => e.ClosingChar).Contains(c))
               {
                    // if closing char is a match with stack top item, pop item from stack,
                    // otherwise return false
                    if (openingCharsStack.Peek() == brackets.Find(e => e.ClosingChar == c).OpeningChar)
                         openingCharsStack.Pop();
                    else return false;
               }
          }
          return true;
     }
}
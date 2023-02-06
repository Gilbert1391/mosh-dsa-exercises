namespace mosh_ds_exercises;

public class StringHelper
{
     private class PairBrackets
     {
          public readonly char OpeningChar;
          public readonly char ClosingChar;
          private PairBrackets(char openingChar, char closingChar)
          {
               ClosingChar = closingChar;
               OpeningChar = openingChar;
          }

          public static List<PairBrackets> GetPairBracketsList()
          {
               var c1 = new PairBrackets('(', ')');
               var c2 = new PairBrackets('[', ']');
               var c3 = new PairBrackets('{', '}');
               var c4 = new PairBrackets('<', '>');
               var brackets = new List<PairBrackets> { c1, c2, c3, c4 };
               return brackets;
          }
     }

     public static char? FindFirstRepeatedChar(string input)
     {
          if (string.IsNullOrEmpty(input)) return null;

          var charsFrequency = new HashSet<char>();

          foreach (var key in input)
          {
               if (charsFrequency.Contains(key)) return key;
               charsFrequency.Add(key);
          }

          return null;
     }
     
     public static char? FindFirstNonRepeatedChar(string input)
     {
          if (string.IsNullOrEmpty(input)) return null;
          
          var charsFrequency = new Dictionary<char, int>();

          foreach (var key in input)
          {
               if (charsFrequency.ContainsKey(key)) ++charsFrequency[key];
               else charsFrequency.Add(key, 1);
          }

          foreach (var key in input)
          {
               if (charsFrequency[key] == 1) return key;
          }

          return null;
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

          var brackets = PairBrackets.GetPairBracketsList();
          var openingCharsStack = new Stack<char>();
          foreach (var c in input)
          {
               if (brackets.Select(e => e.OpeningChar).Contains(c)) openingCharsStack.Push(c);
               
               if (brackets.Select(e => e.ClosingChar).Contains(c))
               {
                    // if stack is not empty and closing char is a match with stack top item,
                    // then pop item from stack otherwise return false
                    if (openingCharsStack.Count > 0 && 
                        openingCharsStack.Peek() == brackets.Find(e => e.ClosingChar == c).OpeningChar)
                         openingCharsStack.Pop();
                    else return false;
               }
          }
          return openingCharsStack.Count == 0;
     }
}
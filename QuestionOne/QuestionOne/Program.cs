using System;
using System.Collections.Generic;

namespace QuestionOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string inputText = "Contrary to popular belief, the pink unicorn flies east";  
            Console.WriteLine(SortText(inputText));
            Console.ReadKey();
        }

        public static string SortText(string inputText)
        {            
            inputText = inputText.ToLower();

            List<string> inputList = new List<string>();
            for (var i = 0; i < inputText.Length; i++)
            {
                if (!char.IsWhiteSpace(inputText[i]) && char.IsLetterOrDigit(inputText[i]))
                {
                    inputList.Add(inputText[i].ToString());
                }
            }

            inputList = CustomSort(inputList);

            string outputString = string.Empty;
            foreach (var i in inputList)
            {
                outputString += i;
            }

            return outputString;
        }
        private static List<string> CustomSort(List<string> InArg)
        {
            string tempChar = string.Empty;
            for (var i = 0; i < InArg.Count; i++)
            {
                for (var o = 0; o < InArg.Count; o++)
                {
                    if (string.Compare(InArg[i], InArg[o]) < 0)
                    {
                        tempChar = InArg[o];
                        InArg[o] = InArg[i];
                        InArg[i] = tempChar;
                    }
                }
            }
            return InArg;
        }
    }
}

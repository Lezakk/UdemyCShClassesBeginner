using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyClassesBeginner
{
    public class ArraysAndLists
    {
        public string Facebook(List<string> list)
        {
            if (list.Count == 0) return "";
            else if (list.Count == 1) return String.Format("{0} likes your post.", list[0]);
            else if (list.Count == 2) return String.Format("{0} and {1} like your post.", list[0], list[1]);
            else return String.Format("{0}, {1} and {2} others like your post.", list[0], list[1], list.Count - 2);
        }
        public string ReverseString(string reverseMe)
        {
            char[] reverseArr = new char[reverseMe.Length];
            int i = 0;
            foreach (var item in reverseMe)
            {
                reverseArr[i] = item;
                i++;
            }
            Array.Reverse(reverseArr);
            string result = "";
            foreach (var item in reverseArr)
            {
                result += item;
            }
            return result;
        }
        public static void EnterFiveNum()
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (Array.IndexOf(arr, input) == -1) arr[i] = input;
                else
                {
                    Console.WriteLine("You already put this numer into array");
                    i--;
                }
                
            }
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write(item);
            }

        }
        public static void ContunouslyEnterNumersToListUntilQuit()
        {
            List<int> list = new List<int>();
            List<int> uniqueList = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Quit") break;
                else list.Add(int.Parse(input));

            }
            foreach (var item in list)
            {
                if (uniqueList.IndexOf(item) == -1) uniqueList.Add(item);
            }
            foreach (var item in uniqueList)
            {
                Console.Write(item + " ");
            }
        }
    }

}

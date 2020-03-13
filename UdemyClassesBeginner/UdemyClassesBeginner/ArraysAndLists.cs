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
    }

}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UdemyClassesBeginner
{
    public class Text
    {
        public string Consecutive(string text)
        {
            int notConsecutiveFlag = 0;
            List<string> numList = new List<string>(text.Split("-"));
            if (int.Parse(numList[0]) > int.Parse(numList[1]))
            {
                int startNum = int.Parse(numList[0]);
                for (int i = 0; i < numList.Count; i++)
                {
                    if (int.Parse(numList[i]) == startNum) continue;
                    else notConsecutiveFlag++;
                    startNum--;
                }
            }
            else if (int.Parse(numList[0]) < int.Parse(numList[1]))
            {
                int startNum = int.Parse(numList[0]);
                for (int i = 0; i < numList.Count; i++)
                {
                    if (int.Parse(numList[i]) == startNum) continue;
                    else notConsecutiveFlag++;
                    startNum++;
                }
            }
            else
            {
                notConsecutiveFlag++;
            }
            if (notConsecutiveFlag > 0) return "Not Consecutive";
            else return "Consecutive";
        }

        public string HyphenNumbers(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return "Exit";
            List<string> input = new List<string>(numbers.Split('-'));
            if (input.Count != input.Distinct().Count()) return "Duplicates";
            else return "Good";
        }
    }
}

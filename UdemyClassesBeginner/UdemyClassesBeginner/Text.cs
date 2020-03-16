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

        public string ValidTime(string time)
        {
            if(String.IsNullOrEmpty(time)) return "Invalid Time";
            int hours = int.Parse(time.Substring(0, 2));
            int minutes = int.Parse(time.Substring(3));
            if (hours >= 0 && hours < 24 && minutes >= 0 && minutes < 60) return "Ok";
            else return "Invalid Time";
        }

        public string PascalCase(string text)
        {
            StringBuilder strBuilder = new StringBuilder();
            List<string> singleWords = new List<string>(text.Split(' '));
            foreach (var word in singleWords)
            {
                strBuilder.Append(word.Substring(0,1).ToUpper());
                strBuilder.Append(word.Substring(1).ToLower());
                Console.WriteLine(strBuilder);
            }
            return strBuilder.ToString();

        }
    }
}

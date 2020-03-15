using System;
using System.Collections.Generic;
using System.Text;

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
    }
}

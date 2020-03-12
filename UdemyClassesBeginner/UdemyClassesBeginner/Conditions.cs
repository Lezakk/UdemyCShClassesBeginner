using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyClassesBeginner
{
    public class Conditions
    {
        public string ValidTest(int number)
        {
            var result = number > 0 && number < 11 ? "Valid" : "Invalid";
            return result;
        }

        public int WhitchIsBigger(int firstNumber, int secontNumber)
        {
            var result = firstNumber >= secontNumber ? firstNumber : secontNumber;
            return result;

        }

        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }



        public void InsertValuesToHeightAndWidth()
        {
            this.Height = Int32.Parse(Console.ReadLine());
            this.Width = int.Parse(Console.ReadLine());
        }
        public string LandscapeOrPortrait(int height, int width)
        {
            var result = height > width ? "Portrait" : "Landscape";
            return result;
        }

        public static int HowManyPoints(int velocity)
        {
            return velocity > 0 ? velocity/5 : 0;
        }

        public string WhatsWrongPoliceman(int speedLimit, int velocity)
        {
            var points = Conditions.HowManyPoints(velocity - speedLimit);
            if (points == 0) return "Ok";
            else if (points > 0 && points < 12) return points.ToString();
            else return "License Suspended";

        }


    }
}

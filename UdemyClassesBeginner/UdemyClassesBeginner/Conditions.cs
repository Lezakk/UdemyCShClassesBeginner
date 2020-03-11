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

        public int HowManyPoints(int velocity)
        {
            return velocity / 5;
        }

        
    }
}

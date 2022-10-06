using System;

namespace Open_Lab_03._06
{
    public class Checker
    {
        public bool HasSpaces(string str)
        {
            bool stringSpace = str.Contains(" ");
            return stringSpace;
        }
    }
}

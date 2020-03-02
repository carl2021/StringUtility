using System;

namespace StringUtilty
{
    public class StringUtility
    {
        public StringUtility()
        {
            
        }

        public int NumberOfOcc(string stringToTest, string stringToFind)
        {
            //if (stringToTest.Contains(stringToFind)) return 1;
            //else
            //{
            //    return 0;
            //}
            int count = 0;
            if (stringToTest == null)
            {
                return -1;
            }
            else if (stringToTest == "" && stringToFind == "")
            {
                return 1;
            }
            

            foreach (char c in stringToTest.ToLower())
            {
                if (stringToFind.Length > 0)
                {
                    if (c == stringToFind.ToLower()[0])
                    {
                        count++;
                    }
                }

            }

            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace consoleApp.CodeWar
{
    public static class Solutions
    {
        public static bool IsTrue(string str)
        {
            if (string.IsNullOrEmpty(str))
                return true;

            str = str.ToUpper();
            var strCharacter = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (strCharacter.Contains(str[i]))
                    return false;

                strCharacter.Add(str[i]);
            }

            return true;
        }
    }
}

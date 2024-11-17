﻿using System.Security.Policy;

namespace Windows_Forms.Shared
{
    public class Format
    {
        public static string Capitalizar(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
    }
}
﻿namespace BlazorApp.Shared
{
    public class Errors
    {
        private static List<string> _errores = new List<string>();
        public static List<string> Errores
        {
            get
            {
                return _errores;
            }
        }
    }
}
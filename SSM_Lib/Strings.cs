using System;
using System.Collections.Generic;
using System.Text;

namespace SSM_Lib
{
    public static class Length
    {
        public static int GetLength(string Input)
        {
            if ((Input.Equals(null) || (Input.Equals("")))) return 0;
            byte[] temp = Encoding.ASCII.GetBytes(Input);
            return temp.Length;
        }
        public static bool IsLength(string Input, int length)
        {
            if ((Input.Equals(null) || (Input.Equals("")))) return false;
            byte[] temp = Encoding.ASCII.GetBytes(Input);
            var istrue = false;
            if (temp.Length == length) istrue = true;
            return istrue;
        }
        public static bool IsNullorEmpty(string Input)
        {
            if ((Input.Equals(null) || (Input.Equals("")))) return true;
            else return false;
        }
    }
    public static class Manipulate
    {
        public static string RemoveString(string inputString, string removalString) => inputString.Replace(removalString, "");
        public static class Trim
        {
            public static string Start(int amount, string input)
            {
                var temp = input.ToCharArray();
                int modAmount = amount - 1;
                int count = 0;
                while (count != modAmount)
                {
                    temp[count] = '\0';
                    count++;
                }
                var temp2 = new string(temp);
                return temp2;
            }
            public static string End(int amount, string input)
            {
                var temp = input.ToCharArray();
                int modAmount = temp.Length - amount - 1;
                int count = 0;
                var temp2 = new char[temp.Length];
                while (count != modAmount)
                {
                    temp2[count] = temp[count];
                    count++;
                }
                var temp3 = new string(temp);
                return temp3;
            }

        }
    }
    public static class Convert
    {
        public static Dictionary<string, string> ToDictionary(string keys, string values, char delimiter)
        {
            var temp = new Dictionary<string, string>();
            var keyBreak = keys.Split(delimiter);
            var valueBreak = values.Split(delimiter);
            var count = 0;
            foreach (var item in keyBreak)
            {
                temp.Add(item, valueBreak[count]);
                count++;
            }
            return temp;
        }
        public static Dictionary<string, string> ToDictionary(string[] keys, string[] values)
        {
            var temp = new Dictionary<string, string>();
            var count = 0;
            foreach (var item in keys)
            {
                temp.Add(item, values[count]);
                count++;
            }
            return temp;
        }
        public static string CompileString(string[] input)
        {
            var temp = "";
            foreach (var item in input)
            {
                temp += item;
            }
            return temp;
        }
        public static string CompileString(char[] input)
        {
            var temp = "";
            foreach (var item in input)
            {
                temp += item;
            }
            return temp;
        }
        public static string CompileString(byte[] input)
        {
            var temp = "";
            foreach (var item in input)
            {
                temp += item;
            }
            return temp;
        }
    }
}

using System;

namespace wordSplit
{
    class Program
    {
        public static string WordSplit(string source, string[] strArr)
        {

            // code goes here  
            string result="";

            foreach (var item in strArr)
            {
                if (item.Length>2 && source.Contains(item))
                {
                    result += item + ",";
                }

            }

            return result;

        }
        static void Main(string[] args)
        {
            //string[] itemArr = Array.ConvertAll(Console.ReadLine().ToString().Split(','), aTemp => Convert.ToString(aTemp));
            string source = "baseball";
            string words=  "a,all,b,ball,bas,base,cat,code,d,e,quit,z";
            string[] itemArr = Array.ConvertAll(words.Split(','), aTemp => Convert.ToString(aTemp));

            Console.WriteLine(WordSplit(source, itemArr));
        }
    }
}

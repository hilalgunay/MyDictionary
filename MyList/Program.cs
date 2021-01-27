using System;

namespace MyDictionary
{
    class  Program
    {
        static void Main(string[] args)
        {
            MyDictionay<int, string> myDictionary = new MyDictionay<int, string>();


            myDictionary.Add(1, "Muğla");
            myDictionary.Add(2, "Bursa");
        }

    }
}

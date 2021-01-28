using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryManager<int,string> dictionary = new DictionaryManager<int,string>();
            dictionary.Add(20,"Taha");
            dictionary.Add(20,"Ender");
            dictionary.ShowAll();

        }
    }
}

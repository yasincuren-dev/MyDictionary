using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> cities = new MyDictionary<string, string>();

            cities.Add("34", "İstanbul");
            cities.Add("10", "Bandırma");
            cities.Add("17", "Çanakkale");

            cities.ShowItems();
        }
}
}

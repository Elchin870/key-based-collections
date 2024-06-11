using System.Collections;
using System.Collections.Concurrent;

namespace key_based_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)Dictionary<TKey, TValue>
            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(1, "Apple");
            //dictionary.Add(2, "Banana");
            //dictionary.Add(3, "Cherry");

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine($"Meyve: {item.Value}  Say: {item.Key}");

            //}



            //2)SortedDictionary<TKey, TValue>
            //SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();
            //sortedDict.Add(3, "Cherry");
            //sortedDict.Add(1, "Apple");
            //sortedDict.Add(2, "Banana");

            //foreach (var item in sortedDict)
            //{
            //    Console.WriteLine($"Meyve: {item.Value}  Say: {item.Key}");
            //}



            //3)SortedList<TKey, TValue>
            //SortedList<int, string> sortedList = new SortedList<int, string>();
            //sortedList.Add(3, "Cherry");
            //sortedList.Add(1, "Apple");
            //sortedList.Add(2, "Banana");

            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine($"Meyve: {item.Value} Say: {item.Key}");
            //}



            //4)Hashtable
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "Apple");
            //hashtable.Add(2, "Banana");
            //hashtable.Add(3, "Cherry");

            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Meyve: {entry.Value}  Say: {entry.Key}");
            //}



            //5)ConcurrentDictionary<TKey, TValue>
            //ConcurrentDictionary<int, string> concurrentDict = new ConcurrentDictionary<int, string>();
            //concurrentDict.TryAdd(1, "Apple");
            //concurrentDict.TryAdd(2, "Banana");
            //concurrentDict.TryAdd(3, "Cherry");

            //foreach (var item in concurrentDict)
            //{
            //    Console.WriteLine($"Meyve: {item.Value}  Say: {item.Key}");
            //}

        }
    }
}

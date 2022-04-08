using System;

namespace CustomList
{
    class Program
    {

        static void Main(string[] args)
        {
            CustomList<string> List = new CustomList<string>();
            List.Add("A");
            List.Add("B");
            List.Add("C");
            
            List.Remove("A");
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
        }
    }
}

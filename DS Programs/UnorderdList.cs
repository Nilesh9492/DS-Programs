using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DS_Programs
{
    class UnorderdList
    {
        public static void List()
        {
            string text = File.ReadAllText(@"E:\NILESH\C#\DS Programs\string.txt");
            string[] textArray = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            LinkedList<string> list = new LinkedList<string>();
            for (int i = textArray.Length - 1; i >= 0; i--)
            {
                list.InsertFront(textArray[i]);
            }
            list.View();
            Console.WriteLine("\nEnter a string which you want to search");
            string searchStr = Console.ReadLine();
            if (list.Search(searchStr))
            {
                list.DeleteElement(searchStr);
            }
            else
            {
                list.InsertFront(searchStr);
            }
            string textFile = list.ReturnString();
            File.WriteAllText(@"E:\NILESH\C#\DS Programs\string.txt", textFile);
            list.View();

        }
    }
}
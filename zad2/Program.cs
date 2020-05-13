using System;
using System.Linq;
using System.Xml;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] index = new int[2] { 0, 0 };

            while (true)
            {
                index = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if ((index[0] == -1 && index[1] == -1)) break;

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(args[0]);
                XmlNodeList rows = xmlDoc.GetElementsByTagName("row");
                XmlDocument row = new XmlDocument();
                if (rows.Count <= index[0] || index[0] < 0)
                {
                    Console.WriteLine("EMPTY");
                    continue;
                }
                row.LoadXml("<row>" + rows.Item(index[0]).InnerXml + "</row>");
                XmlNodeList cells = row.GetElementsByTagName("cell");
                if (cells.Count <= index[1] || index[1] < 0)
                {
                    Console.WriteLine("EMPTY");
                    continue;
                }
                String cell = cells.Item(index[1]).InnerText;
                Console.WriteLine(cell);
            };
        }
    }
}

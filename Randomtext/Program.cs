using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomtext
{
    internal class Program
    {
        static List<char> chars = new List<char>()
        {
            'a','b','c','d','e','f','g','h','i','h','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','0','1','2','3','4','5','6','7','8','9','!','?','?'
        };

        static void Main(string[] args)
        {
            string file = "C://Users/Luke/RT.txt";
            if (!File.Exists(file))
            {
                File.Create(file);
            }
            else
            {
                Console.WriteLine("Datei existiert");
            }

            StreamWriter sw = new StreamWriter(file);
            Random r = new Random();
            int rows = 3000000;
            int columns = 999;

            for (int i = 0; i < rows; i++)
            {
                string line = "";
                for (int j = 0; j < columns; j++)
                {
                    line += chars[r.Next(0, chars.Count)].ToString();
                    //Console.WriteLine(chars[r.Next(0, chars.Count)].ToString() + " " + i + " " + line);
                }
                sw.WriteLine(line);
                Console.WriteLine($"{i + 1}/{rows}");
                //Console.WriteLine(line);
            }

            sw.Close();
            Console.ReadKey();
        }
    }
}

using System;
using System.IO;
using System.Reflection;

namespace Lab3
{
    internal class Program
    {
        static void readFileWriteFile()
        {
            string filePath1 = "example.txt";
            string filePath2 = "output.txt";
            using (FileStream fileStream1 = new FileStream(filePath1, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fileStream1))

            using (FileStream fileStream2 = new FileStream(filePath2, FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fileStream2))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }
                Console.WriteLine("Dữ liệu được sao chép từ file input sang file output");
            }
        }

        
        static void Main()
        {
    readFileWriteFile();
        }
    }
}

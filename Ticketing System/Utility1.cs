using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreation_Center_Ticketing_Method
{
    class Utility1
    {
        private static string _filePath = "price.txt";
        public static string WriteToFile(string data)
        {
            if (!File.Exists(_filePath))
            {
                using (File.Create(_filePath));
            }
            using (StreamWriter outputFile = new StreamWriter(_filePath))
            {
                outputFile.WriteLine(data);
            }
            return "success";
        }

        public static string ReadFromFile()
        {
            if (File.Exists(_filePath))
            {
                string data = File.ReadAllText(_filePath);

                return data;
            }
            return null;
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreation_Center_Ticketing_Method
{
    public static class Utility
    {

        private static string _filePath = "Customers.txt";
        public static string WriteToFile(string data) { 
            if (!File.Exists(_filePath))
            {
                using (File.Create(_filePath)) ;
            }
            using (StreamWriter outputFile = new StreamWriter(_filePath,false))
            { 
                outputFile.WriteLine(data);
            }
            return "success";
        }
        public static string UpdateToFile(string data)
        {
            using (var writer = File.AppendText(_filePath))
            {
                writer.Write(data);
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



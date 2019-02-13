using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Аружан\Desktop\c# folder\path.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("I am just copying some text to my file");
            sw.Close();
            fs.Close();
            string sourcePath = @"C:\Users\Аружан\Desktop\c# folder\path.txt";
            string targetPath = @"C:\Users\Аружан\Desktop\c# folder\path1.txt";
            File.Copy(sourcePath, targetPath, true);
            File.Delete(sourcePath);
        }
    }
}
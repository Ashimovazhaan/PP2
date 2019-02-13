using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void OpenFilePalindrome()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Аружан\Desktop\c# folder\Palindrome.txt");
            string s = sr.ReadToEnd(); // Create string to Write Down the word from the beginning to the end  from the "input" file into s
            bool Check = true; // Create bool for cheching 
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - 1 - i])// Condition which comes into if i-th element of the word is not equal s.Length - 1-ki        
                    Check = false;
            }
            if (Check == true) // Condition Which Shows Yes if Chech is equal true in the end
                Console.Write("Yes");
            else
            {
                Console.Write("No"); // Show NO if Check is equal false
            }
            sr.Close(); // Do not foreget to close the project
        }
        static void Main(string[] args)
        {
            OpenFilePalindrome(); // Call the function to check for palindrom
            Console.ReadKey();
        }
    }
}

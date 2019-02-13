using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine(); // INPUT THE NUMBER IN THE FIRST LINE
            string[] s2 = Console.ReadLine().Split(); // SEPARATE A STRING BY ARRAY OF STRING
            int a = int.Parse(s1); // CHANGE THE STRING TYPE=> INTEGER TYPE
            string t = ""; //CREATE A NEW EMPTY STRING TO SAVE PRIME NUMBERS
            int count1 = 0; // COUNTER OF WHOLE PRIME NUMBERS
            for (int i=0; i<a; i++) //CREATE A CYCLE THAT RUNS THROUGH NUMBERS OF ARRAY
            {
                int b = int.Parse(s2[i]); // CHANGE THE STRING TYPE OF NUMBERS IN ARRAY TO INTEGER TYPE
                int count = 0; // NEW INTEGER TO COUNT AND REFRESH THE OWN MEAN TO 0 FOR EACH NEW i

                for (int j = 2; j <= Math.Sqrt(b); j++) //CREAT A CYCLE THAT RUN FROM 2 TO MEAN SQRT OF INTEGERS IN ARRAY
                {
                    if (b % j == 0)
                        count++; //TO FIND ALL DIVISORS OF B BY THIS CONDITION
                }
                if (count == 0 && b!=1) // CONDITION OF CHECKING PRIME OR NOT
                {
                    t += s2[i] + " ";  // TO ADD A PRIME NUMBERS TO STRING T IF CONDITION IS TRUE 
                    count1++; // COUNT THE WHOLE PRIME NUMBERS

                }
            }
            Console.WriteLine(count1); // OUTPUT THE COUNTER
            Console.Write(t); // OUTPUT PRIME NUMBERS
        }
    }
}

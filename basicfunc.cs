using System.Collections.Generic;
using System.Linq;
using System;

namespace basicfunction
{
    class Program
    {
        static void Main(string[] args)
        {  
            addtoarray();
        }

        static void hitungjumlahkarakter()
        {
            string input;
            
            Console.WriteLine("Input: "); input = Console.ReadLine();
            Console.WriteLine($"Output: {input.Length}");

        }

        static void grade()
        {
            int input;
            
            Console.WriteLine("Input: "); 
            input = Int32.Parse(Console.ReadLine());
            
            if(input >= 90)
            { Console.WriteLine("Output: A");
            }
            else if (input>=80 && input<=89)
            {
                Console.WriteLine("Output: B");
            }

            else if( input>=70 && input<=79)
            {
                Console.WriteLine("Output: C");
            }

             else if( input>=60 && input<=69)
            {
                Console.WriteLine("Output: D");
            }
            else
            {
                Console.WriteLine("Output E");
            }        
            
        }

        static void ganjilgenap()
        {
            int input;
            
            Console.WriteLine("Input: "); 
            input = Int32.Parse(Console.ReadLine());
            
            if(input%2==0)
            { Console.WriteLine("Output: Genap");
            }
            else 
            {
                Console.WriteLine("Output: Ganjil");
            }
        }

        static void kabisat()
        {
             int input;
            
            Console.WriteLine("Input: "); 
            input = Int32.Parse(Console.ReadLine());
            
            if(input%400==0)
            { Console.WriteLine("Output: Kabisat");
            }
            else if(input%4==0 && input%100==0)
            {
                Console.WriteLine("Output: Bukan Kabisat");
            }
            else if(input%4==0)
            {
                Console.WriteLine("Output: Kabisat");
            }
            
            else
            {
                Console.WriteLine("Output: Bukan Kabisat");
            }
        }


        static void filmrating()
        {
            int input;
            
            Console.WriteLine("Input: "); 
            input = Int32.Parse(Console.ReadLine());
            
            if(input>=21)
            { Console.WriteLine("Output: DEWASA");
            }
            else if(input>=13 && input<=20)
            {
                Console.WriteLine("Output: REMAJA");
            }
            else if(input>=9 && input<=12)
            {
                Console.WriteLine("Output: BIMBINGAN ORANG TUA");
            }
            else
            {
                Console.WriteLine("SEMUA USIA");

            }
        }

        static void looprange()
        {  int input1;            
            Console.WriteLine("Input pertama: "); 
            input1 = Int32.Parse(Console.ReadLine());

           int input2;            
            Console.WriteLine("Input kedua: "); 
            input2 = Int32.Parse(Console.ReadLine());
            Console.Write("Output: ");

            foreach( int index in Enumerable.Range(input1, input2))
            {    
                // int index2 =index.Select(c => int.Parse(c.ToString())).ToList();
                Console.Write($"{index},");
            }

        }
        static void ganjil100()
        {
            int bil1=1;
            int bil2=100;
            Console.Write("Output: ");

            foreach( int index in Enumerable.Range(bil1, bil2))
            {    
                if(index%2!=0)
                Console.Write($"{index},");
            }
        }

          static void kelipatan1000()
        {
            int bil1=1;
            int bil2=1000;

            foreach( int index in Enumerable.Range(bil1, bil2))
            {    
                if(index%100==0)
                {
                Console.WriteLine($"{index}.Kelipatan Seratus");
                }
                 else if(index%2==0 && index%5==0)
                {
                    Console.WriteLine($"{index}.Genap Kelipatan Lima");
                }
                  else if(index%2!=0 && index%5==0)
                {
                    Console.WriteLine($"{index}.Ganjil Kelipatan Lima");
                }                          
                else if(index%2==0)
                {
                Console.WriteLine($"{index}.Genap");
                }
                else if(index%2!=0)
                {Console.WriteLine($"{index}.Ganjil");}
            }
        }

        static void balikkata()
        {
            string kata = "saya ingin makan nasi goreng";
            
            string[] kata2 = kata.Split(" ");
           
            Array.Reverse(kata2);
            string kata3 = String.Join(" ", kata2);
            Console.Write(kata3);
            
        }

        static void addtoarray()
        {
            string[] stuff = {"Meja", "Buku", "Topi", "Baju", "Kayu"};
            List<string> tampung = stuff.ToList();
            // foreach(var item in tampung)

            tampung.Add("Celana");
            tampung.Insert(0, "Handuk");

            string[] stuff2 = tampung.ToArray();
            foreach(var item in stuff2)
            {
            Console.Write($"{item}, ");

            }

           
        }


    }
}

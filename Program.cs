using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //for (int i = 0; i < 20; i++)
            //{
            //  Console.WriteLine(p.c(i));
            //    Console.ReadLine();
            //}

            inr();

        }

        public Double c (int x)
        {


            if (x%2 == 0)
            {
            return   (double)(x / 2);
            }
            if (x %3 == 0)
            {
                return (double)(x * 3) + 1;
            }
            return 0;
        }

        public static void inr()
        {
            string input = "abbcccddddcccbba";
            char[] cInput = input.ToCharArray();
            int count = 0;
            int BestIndex = 0;
            for (int i = 0; i < cInput.Length; i++)
            {
                if (i!=0)
                {
                    if (cInput[i] == cInput[i - 1])
                    {
                        
                        if (cInput[i] <= cInput[i - 1])
                        {
                            if (cInput[i] != cInput[BestIndex])
                            {
                                count++;
                                BestIndex = count - 1;
                            }
                       
                        
                         
                         
                        }

                    }

                }
               
            }

            Console.WriteLine(BestIndex);
            Console.ReadLine();



        }
    }
}

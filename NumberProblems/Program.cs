using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Q19();
        }

        public static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int Number = int.Parse(Console.ReadLine());
            return Number;
        }
        public static void Q1()
        {
            int Value = GetInteger("Enter the number:");
            int count = 0;
            while (Value != 0)
            {
                Value = Value / 10;
                count++;
            }
            Console.WriteLine(count);
        }

        public static void Q2()
        {
            int Value = GetInteger("Enter the number:");
            int count = 0;
            while (Value != 0)
            {
                Value = Value / 10;
                count++;
            }
            Console.WriteLine(count);
            if (count % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        public static void Q3()
        {
            int Value = GetInteger("Enter the number:");
            int sum = 0;
            while (Value != 0)
            {
                int temp = Value % 10;
                sum = sum +temp;
                Value = Value / 10;
               
            }
            Console.WriteLine(sum);
        }

        public static void Q4()
        {
            int Value = GetInteger("Enter the number:");
            int count = 0;
            int Oddsum = 0;
            int Evensum = 0;
            while (Value != 0)
            {
                Value = Value / 10;
                count++;
               
                if (count % 2 == 0)
                {
                   
                    Evensum = Evensum + count;
                }
                else
                {
                    
                    Oddsum = Oddsum + count;
                }
            }
            Console.WriteLine(Evensum);
            Console.WriteLine(Oddsum);
            
           
        }
        public static void Q5()
        {
            int Value = GetInteger("Enter the number:");
            int count= 0;
            int Oddsum = 0;
            int Evensum = 0;
            while (Value != 0)
            {
                Value = Value / 10;
                count++;

                if (count % 2 == 0)
                {

                    Evensum++;
                }
                else
                {

                    Oddsum++;
                }
            }
            Console.WriteLine(Evensum);
            Console.WriteLine(Oddsum);
        }

        public static void Q6()
        {
            int Value = GetInteger("Enter the number:");
            
            int Oddsum = 0;
            int Evensum = 0;
            while (Value != 0)
            {
                int temp = Value % 10;

                if (temp % 2 == 0)
                {

                    Evensum = Evensum + temp;
                }
                else
                {

                    Oddsum = Oddsum + temp;
                }
                Value = Value / 10;
            }
            Console.WriteLine(Evensum);
            Console.WriteLine(Oddsum);
         }

        public static void Q7()
        {
             int Number = GetInteger("Enter the number:");
             int result = LastDigit(Number);
             Console.WriteLine("Last digit:"+result);
        }

        public static int  LastDigit(int Number)
        {
            return (Number % 10);
        }

        public static void Q8()
        {
            int Number = GetInteger("Enter the number:");
            int result = FirstDigit(Number);
            Console.WriteLine("First digit:" + result);
        }

        public static int FirstDigit(int Number)
        {
            while (Number >= 10)
            {
                Number = Number / 10;
            }
            return Number;
        }

        public static void Q9()
        {
            int Number = GetInteger("Enter the number:");
            int largest = 0;
            while (Number != 0)
            {
                int temp = Number % 10;
                largest = Math.Max(temp, largest);
                Number = Number / 10;
            }
            Console.WriteLine(largest);
        }

        public static void Q10()
        {
            int Number = GetInteger("Enter the number:");
            int digit = 0;
            int position = 1;
            int largest = 0;
            while (Number != 0)
            {
                int temp = Number % 10;
                if (largest < temp)
                {
                    largest = temp;
                    digit = position;
                }
                position = position * 10;
                Number = Number / 10;
            }
            Console.WriteLine("largest:{0} and position:{1}s",largest,digit);
        }

        public static void Q11()
        {
            int Number = GetInteger("Enter the number:");
            int smallest= 9;
            while (Number != 0)
            {
                int temp = Number % 10;
                smallest = Math.Min(temp, smallest);
                Number = Number / 10;
            }
            Console.WriteLine(smallest);
        }

        public static void Q12()
        {
            int Number = GetInteger("Enter the number:");
            int digit = 0;
            int position = 1;
            int smallest = 9;
            while (Number != 0)
            {
                int temp = Number % 10;
                if (smallest > temp)
                {
                    smallest = temp;
                    digit = position;
                }
                position = position * 10;
                Number = Number / 10;
            }
            Console.WriteLine("smallest:{0} and position:{1}s", smallest, digit);
        }
        public static void Q13()
        {
            int Number = GetInteger("Enter the number:");
            int ReverseNum = ReverseNumber(Number);
            Console.WriteLine(ReverseNum);
        }

        public static int ReverseNumber(int Number)
        {
           
            int position = 0;
            while (Number != 0)
            {
                int temp = Number % 10;
                position = position * 10 + temp;
                Number = Number / 10;
            }

            return position;
        }

        public static void Q14()
        {
            int Number = GetInteger("Enter the number:");
            int result = 0;
            int sum = 0;
            int sum1 = 0;
            while (Number >= 10)
            {
                while (Number != 0)
                {
                    int temp = Number % 10;
                    sum = sum + temp;
                    Number = Number / 10;
                }
                int temp1 = sum % 10;
                sum1 = sum1 + temp1;
               sum = sum / 10;
               result= sum+sum1;
            }
            Console.WriteLine(result);
        }

        public static void Q15()
        {
            int Number = GetInteger("Enter the number:");
            bool value = true;
            int CpValue = Number;
            while (Number != 0)
            {
                int temp = Number % 10;
                if (CpValue % temp == 0)
                {
                    Number = Number / 10;
                    Console.WriteLine(value);
                }
                else
                {
                    Console.WriteLine("False");
                    break;
                }
             }
        }

        public static void Q16()
        {
            int Number = GetInteger("Enter the number:");
            int K = GetInteger("Enter the value for K:");
            int count = 0;
            while (Number != 0)
            {
                int temp = Number % 10;
                if (temp % K == 0)
                {
                    count++;
                }
                Number = Number / 10;
                
            }
           Console.WriteLine(count);
        }

        public static void Q17()
        {
            int Number = GetInteger("Enter the two or three digit number to check wheather it is a palindrome or not:");
           
                int firstdigit = FirstDigit(Number);
                int lastdigit = LastDigit(Number);
                if (firstdigit == lastdigit)
                {
                    Console.WriteLine("It is a palindrome");
                }
                else
                {
                    Console.WriteLine("It is not a palindrome");
                }
        }

        public static void Q18()
        {
            int Number = GetInteger("Enter the number to check wheather it is a palindrome or not:");
            int ReverseNum = ReverseNumber(Number);
            if (Number == ReverseNum)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }
        }

        public static void Q19()
        {
            int Number = GetInteger("Enter the number to find the maximum integer :");
            int Copy = Number;
            int Maxi = 0;
            while (Copy != 0)
            {
                int temp = Copy % 10;
                Maxi = Math.Max(temp, Maxi);
                Copy = Copy / 10;
            }
            Console.WriteLine("Maximum integer in the given number: "+Maxi);
        }

        public static void Q20()
        {
            int Number = GetInteger("Enter the number to find the minimum integer :");
            int Copy = Number;
            int Minm = 9;
            while (Copy != 0)
            {
                int temp = Copy % 10;
                Minm = Math.Min(temp, Minm);
                Copy = Copy / 10;
            }
            Console.WriteLine("Maximum integer in the given number: " + Minm);
        }
    }
}

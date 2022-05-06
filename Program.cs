using System;

namespace Csharp_Array_of_Multiples
{
    class Program
    {
        private static void Main(string[] args)
        {
            program();
        }
        public static void program()
        {
            try
            {
                Console.WriteLine("What multiple of?");
                int multiple_number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Length?");
                int length = Int32.Parse(Console.ReadLine());
                List<int> list_result = multiple(multiple_number, length);
                int[] array_result = list_result.ToArray();
                Console.WriteLine("--Result--");
                foreach (var item in array_result)
                {
                    Console.WriteLine(item.ToString());
                }     
            }
            catch (Exception x)
            {
                Console.WriteLine("Wrong Input");
                program();
            }  
        }
        public static List<int> multiple(int multiple_number, int length)
        {
            int it, number;
            List<int> numberList = new List<int>();
            for (it = 1;it < length; it++)
            {
                number = multiple_number * it;
                numberList.Add(number);
            }
            number = multiple_number * it;
            numberList.Add(number);
            return numberList;
        }
    }
}
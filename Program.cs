using System;

namespace Palyndrome_checking
{
    class Program
    {

        static string ReverseString(string s)  // Думал решить переворот числа через цифры, но плюнул и сделал это через строки, для чего погуглил, вытащив самый красивый результат. :)
        {
            // Convert to char array, then call Array.Reverse.
            // ... Finally use string constructor on array.
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        static void Main()
        {

            

                Console.WriteLine("Palyndrome number checking program\n");
            Int64 OriginalNumber;
            Int64 InvertedNumber;
            

            {
                while (true) // Просто проверка введенного значения
                {
                    Console.Write("Enter the integer number to check: ");
                    if (Int64.TryParse(Console.ReadLine(), out OriginalNumber))
                    {
                        break;
                    }
                    Console.WriteLine("Please enter an int64 value!");
                }
                
                // Флипаем число через двойную конвертацию в строку и обратно. 
                // Проверок не делаем для простоты. Но! Флипнутое число может быть больше, чем Int64 (о, злобный пользователь! ;)
                InvertedNumber = Convert.ToInt64(ReverseString(Convert.ToString(OriginalNumber))); 



                Console.WriteLine("Original Number/Inverted Number/isPalyndrome?: {0}/{1}/{2}", OriginalNumber,InvertedNumber,OriginalNumber==InvertedNumber);


            }
        }
    }
}

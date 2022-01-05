using System;

namespace OccurrenceCharacterWithoutSpace
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string str =  Console.ReadLine();
            Console.WriteLine("\nInput: " + str);

            str = str.Replace(" ", string.Empty);

            while (str.Length > 0)
            {
                Console.Write(str[0] + " = ");
                int count = 0;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str [0] == str [j])
                        count++;
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}

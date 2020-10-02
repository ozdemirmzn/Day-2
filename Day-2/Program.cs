using System;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            string str = User_Input.getUserInput();

            //string str = string.Empty;
            //str = "website";

            while (str.Length > 0)
            {
                Console.Write(str[0] + ": ");
                int count = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i])
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);

                //returns a new string without counted chars
                str = str.Replace(str[0].ToString(), string.Empty);
                 // Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}


using System;

namespace Task91
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ExArray = { "DivideByZeroException", "IndexOutOfRangeException", "InvalidCastException", "NameException", "OverflowException" };

            for (int i = 0; i < ExArray.Length; i++)
            {
                if (ExArray[i] == "DivideByZeroException")
                {
                    try
                    {
                        int x = 5;
                        int y = x / 0;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Возникло исключение DivideByZeroException ");
                    }
                }
                else if (ExArray[i] == "IndexOutOfRangeException")

                {
                    try
                    {
                        int[] numbers = new int[4];
                        numbers[7] = 9;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Возникло исключение IndexOutOfRangeException ");
                    }
                }
                else if (ExArray[i] == "InvalidCastException")

                {
                    try
                    {
                        object obj = "you";
                        int num = (int)obj;
                    }
                    catch (InvalidCastException)
                    {
                        Console.WriteLine("Возникло исключение InvalidCastException ");
                    }
                }
                else if (ExArray[i] == "NameException")

                {
                    try
                    {
                        string name = "";
                        if (name == null || name.Length < 2)
                        {
                            throw new NameException("Возникло исключение NameException ");
                        }
                    }

                    catch (NameException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (ExArray[i] == "OverflowException")

                {
                    try
                    {

                        checked
                        {
                            int u = 1000000000;
                            short p = (short)u;
                        }
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Возникло исключение OverflowException ");
                    }
                }
            }
            Console.Read();
        }
    }
    class NameException : Exception
    {
        public NameException(String message) : base(message) { }
    }
}


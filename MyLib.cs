using System;


namespace MyLib
{
    public static class MyLibClass
    {
        public static int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

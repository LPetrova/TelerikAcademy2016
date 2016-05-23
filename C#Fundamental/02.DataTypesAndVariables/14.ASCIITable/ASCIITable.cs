using System;

class ASCIITable
{
    static void Main()
    {
      
        char symbol;

        for ( int i = 33; i < 127; i++)
        {
            symbol = Convert.ToChar(i);
            Console.Write(symbol);
        }
    }
}


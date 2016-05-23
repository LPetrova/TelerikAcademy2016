using System;

class HexadecimalFormat
{
    static void Main()
    {
        string textNum = "254";
        int parseNum = int.Parse(textNum);
        string hexNum = parseNum.ToString("X");
        Console.WriteLine("0x" + hexNum);
    }
}

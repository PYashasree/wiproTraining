using System;
class Decimal
{
    static int BinaryToDecimal(string binary)

    {
        int decimalValue=Convert.ToInt32(binary,2);
        return decimalValue;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value");
        string binaryString =Console.ReadLine();
        int decimalResult = BinaryToDecimal(binaryString);
        Console.WriteLine($"decimal value of {binaryString} is : {decimalResult}");
}
}
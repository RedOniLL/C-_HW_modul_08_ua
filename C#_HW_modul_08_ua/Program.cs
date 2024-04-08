namespace C__HW_modul_08_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 0:
                    Vector vector1 = new Vector(1, 2, 3);
                    Vector vector2 = new Vector(4, 5, 6);

                    
                    Vector result1 = vector1.MultiplyByScalar(2);
                    Vector result2 = vector1.Add(vector2);
                    Vector result3 = vector1.Subtract(vector2);

                    Console.WriteLine("Multiplication of vectors by a scalar:");
                    Console.WriteLine(result1.ToString());

                    Console.WriteLine("Vector addition:");
                    Console.WriteLine(result2.ToString());

                    Console.WriteLine("Vector subtraction:");
                    Console.WriteLine(result3.ToString());

                    Console.WriteLine("Length of vector 1: " + vector1.Length());
                    Console.WriteLine("Length of vector 2: " + vector2.Length());
                    break;
                case 1:
                    DecimalNumber number = new DecimalNumber(123);

                    string binary = number.ToBinary();
                    string octal = number.ToOctal();
                    string hexadecimal = number.ToHexadecimal();

                    Console.WriteLine("Decimal Number: " + number);
                    Console.WriteLine("Binary Representation: " + binary);
                    Console.WriteLine("Octal Representation: " + octal);
                    Console.WriteLine("Hexadecimal Representation: " + hexadecimal);
                    break;
            }
        }
    }
}

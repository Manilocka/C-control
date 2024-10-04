using System;
using System.Text;

public class Converter
{
    public static string ToRoman(int number)
    {

        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException("number");
        }


        var rNumbers = new (int Value, string Numeral)[]
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (6, "VI"),
            (5, "V"),
            (4, "IV"),
            (2, "II"),
            (1, "I")
        };

        var result = new StringBuilder();


        foreach (var (Value, Numeral) in rNumbers)
        {
            while (number >= Value)
            {
                number -= Value;
                result.Append(Numeral);
            }
        }

        return result.ToString();
    }

    public static void Main()
    {
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string roman = ToRoman(number);
            Console.WriteLine($"{number} is {roman}");
        }
        catch (Exception)
        {
            Console.WriteLine("Попробуйте еще раз. Введите корректное число");
        }

    }
}

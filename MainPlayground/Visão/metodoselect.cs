using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Utilizando o método Select para transformar os números em seus quadrados
        IEnumerable<int> squares = numbers.Select(n => n * n);

        // Imprimindo os quadrados dos números
        foreach (int square in squares)
        {
            Console.WriteLine(square);
        }
    }
}

using Microsoft_Learn;
using System;
using System.Formats.Asn1;

class App
{
    static void Main(string[] args)
    {
        LoopsAndBrachs LoopsAndBrachs = new LoopsAndBrachs();


        LoopsAndBrachs.Nono();
    }


    static void Primeiro()
    {
        int a = 7;
        int b = 4;
        int c = 3;
        int d = (a + b) / c;
        int e = (a + b) % c;
        Console.WriteLine(d);
        Console.WriteLine($"quotient: {d}");
        Console.WriteLine(e);
        Console.WriteLine($"remainder: {e}\n\n");
    }

    static void Segundo()
    {
        int max = int.MaxValue;
        int min = int.MinValue;
        Console.WriteLine($"The range of integers is {min} to {max}\n\n");
    }

    static void Terceiro()
    {
        int max = int.MaxValue;
        int what = max + 3;
        Console.WriteLine($"An example of overflow: {what}\n\n");
    }

    static void Quarto()
    {
        double aa = 5;
        double bb = 4;
        double cc = 2;
        double dd = (aa + bb) / cc;
        Console.WriteLine(dd);
    }

    static void Quinto()
    {


        #pragma warning disable CS8604 // Possible null reference argument.
        int A = int.Parse(s: Console.ReadLine());
        int B = int.Parse(s: Console.ReadLine());
        int X = A + B;

        Console.WriteLine($"X = {X}");

    }

    //Double tem um alcance maior mas precisão limitada se comparado com decimal
    static void Sexto()
    {
        double third = 1.0 / 3.0;
        Console.WriteLine(third);
    }

    static void Setimo()
    {
        Console.WriteLine("Precisão do tipo double");
        double max_double = double.MaxValue;
        double min_double = double.MinValue;
        Console.WriteLine($"The range of double is {min_double} to {max_double}");

        Console.WriteLine("\nPrcisão do tipo decimal");
        decimal min_decimal = decimal.MinValue;
        decimal max_decimal = decimal.MaxValue;
        Console.WriteLine($"The range of the decimal type is {min_decimal} to {max_decimal}");
    }

    static void Oitavo()
    {
        /*
         * O sufixo M nos números é como você indica que uma constante 
         * deve usar o tipo decimal. Caso contrário, o compilador assume
         * o tipo double.
         */

        double a = 1.0;
        double b = 3.0;
        Console.WriteLine(a / b);

        decimal c = 1.0M;
        decimal d = 3.0M;
        Console.WriteLine(c / d);
    }

    static void areaDoCirculo()
    {
        Console.WriteLine("informe o tamanho do raio: ");
        double raio = Convert.ToDouble(Console.ReadLine()); // Converte a entrada para double
        double area = Math.PI * (raio * raio);

        Console.WriteLine($"A área do circulo é {area}");

    }
} 

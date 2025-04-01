using System;


namespace Microsoft_Learn
{
    internal class FirstClass
    {
        public void Nono()
        {
            int alfa = 5;
            int beta = 3;

            if (alfa + beta > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is not greater than 10");
        }

        public void Decimo()
        {
            // Um loop pode gerar linhas enquanto o outro gera colunas
            // Dessa forma podemos criar uma matriz bidemensional
            for (int row = 1; row < 11; row++)
            {
                Console.WriteLine($"Cell {row}");
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }

        public void DecimoPrimeiro()
        {
            {
                int soma = 0;

                for (int i = 1; i <= 20; i++)
                {
                    if (i % 3 == 0) // Verifica se o número é divisível por 3
                    {
                        soma += i; // Adiciona à soma
                    }
                }

                Console.WriteLine("A soma dos números divisíveis por 3 de 1 a 20 é: " + soma);
            }   
        }
    }
}

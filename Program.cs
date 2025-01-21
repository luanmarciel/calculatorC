using System;

class Calculadora
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora fácil!");

        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha o tipo de operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        Console.Write("Digite a operação: ");
        int escolha = Convert.ToInt32(Console.ReadLine());

        double resultado = 0;

        if (escolha == 1)
        {
            resultado = numero1 + numero2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
        }
        else if (escolha == 2)
        {
            resultado = numero1 - numero2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
        }
        else if (escolha == 3)
        {
            resultado = numero1 * numero2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        }
        else if (escolha == 4)
        {
            if (numero2 != 0)
            {
                resultado = numero1 / numero2;
                Console.WriteLine($"O resultado da divisão é: {resultado}");
            }
            else
            {
                Console.WriteLine("Erro: Não é possível dividir por zero.");
            }
        }
        else
        {
            Console.WriteLine("Operação inválida. Tente novamente.");
        }

        Console.WriteLine("Fim! :)");
    }
}

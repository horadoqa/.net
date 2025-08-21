using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Adição (+)");
            Console.WriteLine("2 - Subtração (-)");
            Console.WriteLine("3 - Multiplicação (*)");
            Console.WriteLine("4 - Divisão (/)");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            if (opcao == "0")
                break;

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;
            bool operacaoValida = true;

            switch (opcao)
            {
                case "1":
                    resultado = num1 + num2;
                    break;
                case "2":
                    resultado = num1 - num2;
                    break;
                case "3":
                    resultado = num1 * num2;
                    break;
                case "4":
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                    {
                        Console.WriteLine("Erro: divisão por zero.");
                        operacaoValida = false;
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    operacaoValida = false;
                    break;
            }

            if (operacaoValida)
                Console.WriteLine($"Resultado: {resultado}");

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        Console.WriteLine("Calculadora encerrada.");
    }
}

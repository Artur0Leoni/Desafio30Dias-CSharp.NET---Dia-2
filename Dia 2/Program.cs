using System;


class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;


        while (continuar)
        {
            Console.WriteLine("Calculadora Básica");


            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Escolha a operação: ");
            Console.WriteLine("1 - Soma (+)");
            Console.WriteLine("2 - Subtração (-)");
            Console.WriteLine("3 - Multiplicação (*)");
            Console.WriteLine("4 - Divisão (/)");
            Console.Write("Opção: ");


            int opcao = Convert.ToInt32(Console.ReadLine());
            double resultado = 0;


            switch (opcao)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;


                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;


                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;


                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: divisão por zero não é permitida.");
                    }
                    break;


                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }


            Console.Write("Deseja realizar outro cálculo ? (s / n) : ");
            string resposta = Console.ReadLine().ToLower();
            continuar = (resposta == "s");


            Console.Clear();
        }


        Console.WriteLine("Encerrando a calculadora. Até mais!");
    }
}
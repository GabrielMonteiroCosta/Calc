using System.Runtime.Serialization;
double resultado;


Console.WriteLine("Bem-Vindo a Calculadora do Gabs!");

while (true)
{
    Console.WriteLine("\nDigite uma opção:" +
        "\n (1) Somar\n" +
        "(2) Subtração\n " +
        "(3) Multiplicação\n " +
        "(4) Divisão\n " +
        "(5) Potência\n " +
        "(X) Encerrar a Calculdora.");

    string opcao = Console.ReadLine();

    if (opcao.ToUpper() == "X")
    {
        Console.WriteLine("Programa Encerrado!");
        break;
    }

    switch (opcao.ToUpper())
    {
        case "1":
            resultado = Calculo("\nInsira um valor para efetuar a Soma: ", "\nCaracter inválido para Soma", "somar");
            Console.WriteLine($"O resultado da soma é {resultado}");
            break;
        case "2":
            resultado = Calculo("\nInsira um valor para efetuar a Subtração: ", "\nCaracter inválido para subtrair", "subtracao"); ;
            Console.WriteLine($"O resultado da Subtração é {resultado}");
            break;
        case "3":
            resultado = Calculo("\nInsira um valor para efetuar a Multiplicação: ", "\nCaracter inválido para Multiplicar", "multiplica");
            Console.WriteLine($"O resultado da Multiplicação é {resultado}");
            break;
        case "4":
            resultado = Calculo("\nInsira um valor para efetuar a Divisão: ", "\nCaracter inválido para Dividir", "dividir");
            Console.WriteLine($"O resultado da Divisão é {resultado}");
            break;
        case "5":
            resultado = Calculo("\nInsira um valor para efetuar a Potência: ", "\nCaracter inválido para Potencializar", "potencia");
            Console.WriteLine($"O resultado da Potência é: {resultado}");
            break;
        default:
            Console.WriteLine("Digite um opção válida!");
            break;
    }

    double Calculo(string mensagem, string textoNumInv, string operacao)
    {
        double n1 = PegarNumero(mensagem, textoNumInv);
        double n2 = PegarNumero(mensagem, textoNumInv);

        return operacao switch
        {
            "somar" => n1 + n2,
            "subtracao" => n1 - n2,
            "multiplica" => n1 * n2,
            "dividir" => n1 / n2,
            "potencia" => Math.Pow(n1, n2),
        };

        double PegarNumero(string mensagem, string textoNumInv)
        {
            while (true)
            {
                Console.WriteLine(mensagem);
                string? num = Console.ReadLine();
                if (double.TryParse(num, out double numero))
                {
                    return numero;
                }
                Console.WriteLine(textoNumInv);
            }
        }
    }
}
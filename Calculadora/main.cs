using System;
class Program
{
    static int Soma ( int a, int b)
    {
        return a + b;
    }
    static int Menos (int a, int b)
    {
        return a - b;
    }
    static int Vezes (int a, int b)
    {
        return a * b;
    }
    static double Dividir (double a, double b)
    {
        return a / b;
    }
    static void Main()
    {
        bool program = true;
        while (program == true)
        {
            Console.Write("Digite sua conta: ");
            string conta = Console.ReadLine();
            if (conta == "exit")
            {
                program = false;
            } else
            {
                bool soma = conta.Contains('+');
                bool menos = conta.Contains('-');
                bool vezes = conta.Contains('x');
                bool dividir = conta.Contains('/');
                
                if (soma == true)
                {
                    string[] Numeros = conta.Split('+');
                    Console.WriteLine(Soma(int.Parse(Numeros[0]), int.Parse(Numeros[1])));
                } if (menos == true) {
                    string[] Numeros = conta.Split('-');
                    Console.WriteLine(Menos(int.Parse(Numeros[0]), int.Parse(Numeros[1])));
                } if (vezes == true)
                {
                    string[] Numeros = conta.Split('x');
                    Console.WriteLine(Vezes(int.Parse(Numeros[0]), int.Parse(Numeros[1])));
                } if (dividir == true)
                {
                    string[] Numeros = conta.Split('/');
                    Console.WriteLine(Dividir(double.Parse(Numeros[0]), double.Parse(Numeros[1])));
                }
                
            }
        }
    }
}
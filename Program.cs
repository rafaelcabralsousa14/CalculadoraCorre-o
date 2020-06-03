using System;

namespace CorreçãoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica calc = new CalculadoraCientifica();
            System.Console.WriteLine("Faça um cálculo abaixo \n Utilize: + para soma - para subtração x para multiplicação e / para divisão");
            string calculo = Console.ReadLine();
            calc.ManipularCalculos(calculo);
            System.Console.WriteLine("Resultado: "+calc.resultado);

            calc.resultado = 0;

            System.Console.WriteLine("Digite números separados por vírgula");
            calc.CalcularMedia(Console.ReadLine());
            System.Console.WriteLine("Média: "+calc.resultado);

        }
    }
}

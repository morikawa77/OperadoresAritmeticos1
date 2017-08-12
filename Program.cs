using System;

namespace OperadoresAritmeticos1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int x, y, resultado;
			Console.Write("Digite um número: ");
			x = Convert.ToInt32(Console.ReadLine());
			Console.Write("Digite outro número: ");
			y = Convert.ToInt32(Console.ReadLine());
			resultado = x + y;
			Console.Write("A soma dos dois números é: {0}", resultado);
			Console.ReadLine();
        }
    }
}

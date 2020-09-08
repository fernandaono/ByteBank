using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente contaDaGabriela = new ContaCorrente();
			contaDaGabriela.Titular = "Gabriela";
			contaDaGabriela.Agencia = 863;
			contaDaGabriela.Numero = 86345;

			ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
			contaDaGabrielaCosta.Titular = "Gabriela";
			contaDaGabrielaCosta.Agencia = 863;
			contaDaGabrielaCosta.Numero = 86345;

			int idade = 27;
			int idadeMaisUmaVez = 27;

			Console.WriteLine("Igualdade do tipo referência: " + (contaDaGabrielaCosta == contaDaGabriela));
			Console.WriteLine("Igualdade do tipo valor: " + (idade == idadeMaisUmaVez));

			//as duas passam a apontar para a mesma referência			
			contaDaGabriela = contaDaGabrielaCosta;
			Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

			contaDaGabriela.Saldo = 300;
			Console.WriteLine(contaDaGabriela.Saldo);
			Console.WriteLine(contaDaGabrielaCosta.Saldo);

			if (contaDaGabriela.Saldo >= 100)
			{
				contaDaGabriela.Saldo -= 100;
			}

			Console.ReadLine();
		}
	}
}

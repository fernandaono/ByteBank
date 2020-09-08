using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente contaDobruno = new ContaCorrente();

			contaDobruno.Titular = "Bruno";

			Console.WriteLine(contaDobruno.Saldo);

			bool resultadoDoSaque = contaDobruno.Sacar(50);
			
			Console.WriteLine(resultadoDoSaque);
			Console.WriteLine(contaDobruno.Saldo);

			contaDobruno.Depositar(500);
			Console.WriteLine(contaDobruno.Saldo);

			ContaCorrente contaDaGabriela = new ContaCorrente();

			contaDaGabriela.Titular = "Gabriela";

			Console.WriteLine("Saldo do Bruno: " + contaDobruno.Saldo);
			Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.Saldo);

			bool resultadoTransferencia = contaDobruno.Transferir(200, contaDaGabriela);

			Console.WriteLine("Saldo do Bruno: " + contaDobruno.Saldo);
			Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.Saldo);

			Console.WriteLine("Resultado Transferência: " + resultadoTransferencia);

			Console.ReadLine();
		}
	}
}

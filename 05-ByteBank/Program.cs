using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			//Cliente gabriela = new Cliente();

			//gabriela.Nome = "Gabriela";
			//gabriela.Profissao = "Desenvolvedora C#";
			//gabriela.CPF = "024.588.890-00";

			ContaCorrente conta = new ContaCorrente();

			//conta.Titular = gabriela;
			//conta.Titular = new Cliente();
			
			//conta.Titular.Nome = "Gabriela Costa";
			//conta.Titular.Profissao = "Desenvolvedora C#";
			//conta.Titular.CPF = "024.588.890-00";

			conta.Agencia = 563;
			conta.Numero = 5634527;
			conta.Saldo = 500;

			if(conta.Titular == null)
			{
				Console.WriteLine("Ops, a referência em conta é nula");
			}

			//Console.WriteLine(gabriela.Nome);
			Console.WriteLine(conta.Titular);
			//Console.WriteLine(conta.Titular.Nome);
			//Console.WriteLine(conta.Titular.CPF);
			//Console.WriteLine(conta.Titular.Profissao);

			Console.ReadLine();
		}
	}
}

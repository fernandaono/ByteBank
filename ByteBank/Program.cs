using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{

			Funcionario carlos = new Funcionario();

			carlos.Nome = "Carlos";
			carlos.CPF = "546.879.157-20";
			carlos.Salario = 2000;

			Diretor roberta = new Diretor();
			roberta.Nome = "Roberta";
			roberta.CPF = "562.764.982-63";
			roberta.Salario = 5000;

			Funcionario robertaTeste = roberta;

			Console.WriteLine("Bonificação de uma referencia de Diretor: " + roberta.GetBonificacao());
			Console.WriteLine("Bonificação de uma referencia de Diretor: " + robertaTeste.GetBonificacao());

			GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

			gerenciador.Registrar(carlos);
			gerenciador.Registrar(roberta);

			Console.WriteLine(carlos.Nome);
			Console.WriteLine(carlos.GetBonificacao());

			Console.WriteLine(roberta.Nome);
			Console.WriteLine(roberta.GetBonificacao());

			Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());

			Console.ReadLine();
		}
	}
}

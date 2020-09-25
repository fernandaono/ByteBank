using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
	public class Diretor : Funcionario
	{
		public string Senha { get; set; }
		public Diretor(string cpf) : base(5000, cpf)
		{
			Console.WriteLine("Criando Diretor");
		}

		public bool Autenticar(string senha)
		{
			return Senha == senha;

		}
		public override double GetBonificacao()
		{
			return Salario * 0.5;
		}

		public override void AumentarSalario()
		{
			Salario *= 1.15;
		}
	}
}

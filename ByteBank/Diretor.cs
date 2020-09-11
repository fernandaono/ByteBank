using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
	public class Diretor : Funcionario
	{
		public Diretor(string cpf) : base(cpf)
		{
			Console.WriteLine("Criando Diretor");
		}

		public override double GetBonificacao()
		{
			return Salario + base.GetBonificacao();
		}
	}
}

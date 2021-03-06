﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
	public abstract class Autenticavel : Funcionario
	{
		public Autenticavel(double salario, string cpf)
			: base(salario, cpf)
		{
		}

		public string Senha { get; set; }

		public bool Autenticar(string senha)
		{
			return Senha == senha;
		}
	}
}

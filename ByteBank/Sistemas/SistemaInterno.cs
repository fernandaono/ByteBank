using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
	public class SistemaInterno
	{
		public bool Logar(Diretor funcionario, string senha)
		{
			bool usuarioAutenticado = funcionario.Autenticar(senha);

			if (usuarioAutenticado)
			{
				Console.WriteLine("Seja Bem-vindo ao sistema!");
				return true;
			}
			else
			{
				Console.WriteLine("Senha incorreta");
				return false;
			}
		}

		public bool Logar(GerenteDeConta funcionario, string senha)
		{
			bool usuarioAutenticado = funcionario.Autenticar(senha);

			if (usuarioAutenticado)
			{
				Console.WriteLine("Seja Bem-vindo ao sistema!");
				return true;
			}
			else
			{
				Console.WriteLine("Senha incorreta");
				return false;
			}
		}
	}
}
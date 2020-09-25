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
		public bool Logar (Autenticavel funcionario, string senha)
		{
			bool usuarioAtenticado = funcionario.Autenticar(senha);

			if (usuarioAtenticado)
			{
				Console.WriteLine("Seja Bem-Vindo ao Sistema");
				return true;
			}
			else
			{
				Console.WriteLine("Senha Incorreta");
				return false;
			}
		}
		
	}
}
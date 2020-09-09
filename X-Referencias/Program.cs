using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Referencias
{
	public class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente contaDaCamila = new ContaCorrente();
			contaDaCamila.Titular = new Cliente();

			contaDaCamila.Titular.Nome = "Camila";

			Console.WriteLine(contaDaCamila.Titular.Nome);
			Console.ReadLine();
		}
	}
}

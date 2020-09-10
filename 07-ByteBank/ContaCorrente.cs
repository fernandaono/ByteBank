
namespace _07_ByteBank
{
	public class ContaCorrente
	{
		private int _Agencia;
		public Cliente Titular { get; set; }
		public static int TotalDeContasCriadas { get; private set; }

		public int Agencia
		{
			get
			{
				return _Agencia;

			}
			set
			{
				if (value <= 0)
				{
					return;
				}

				_Agencia = value;
			}
		}
		public int Numero { get; set; }
		public double _Saldo = 100;

		public double Saldo
		{
			get
			{
				return _Saldo;
			}
			set
			{
				if (value < 0)
				{
					return;
				}

				_Saldo = value;
			}
		}

		public ContaCorrente(int agencia, int numero)
		{
			Agencia = agencia;
			Numero = numero;

			TotalDeContasCriadas++;
		}


		public bool Sacar(double valor)
		{
			if (_Saldo < valor)
			{
				return false;
			}
			else
			{
				_Saldo -= valor;
				return true;
			}

		}

		public void Depositar(double valor)
		{
			_Saldo += valor;
		}

		public bool Transferir(double valor, ContaCorrente contaDestino)
		{
			if (_Saldo < valor)
			{
				return false;
			}
			else
			{
				_Saldo -= valor;
				contaDestino.Depositar(valor);
				return true;
			}
		}

	}
}



namespace _06_ByteBank
{
	public class ContaCorrente
	{
		public Cliente Titular { get; set; }
		public int Agencia { get; set; }
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


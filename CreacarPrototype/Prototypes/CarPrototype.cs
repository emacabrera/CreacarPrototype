using System;
namespace CreacarPrototype.Prototypes
{
	public abstract class CarPrototype
	{
		protected string _motor;
		protected string _marca;
		protected string _modelo;
		protected int _puertas;

		public string Motor { set => _motor = value; }
        public string Marca { set => _marca = value; }
        public string Modelo { set => _modelo = value; }
        public int Puertas { set => _puertas = value; }

        public abstract CarPrototype Clone();
		public abstract string Show();
	}
}


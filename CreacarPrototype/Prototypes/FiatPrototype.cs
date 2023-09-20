using System;
namespace CreacarPrototype.Prototypes
{
	public class FiatPrototype : CarPrototype
	{
        public FiatPrototype()
        {
            _marca = "Fiat";
        }

        public override CarPrototype Clone()
        {
            return (FiatPrototype)this.MemberwiseClone();
        }

        public override string Show()
        {
            return $"Marca: {_marca}. Modelo: {_modelo}. " +
                $"Motor: {_motor}. Puertas: {_puertas}";
        }
    }
}


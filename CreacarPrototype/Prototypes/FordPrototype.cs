using System;
namespace CreacarPrototype.Prototypes
{
    public class FordPrototype : CarPrototype
    {
        public FordPrototype()
        {
            _marca = "Ford";
        }

        public override CarPrototype Clone()
        {
            return (FordPrototype)this.MemberwiseClone();
        }

        public override string Show()
        {
            return $"Marca: {_marca}. Modelo: {_modelo}. " +
                $"Motor: {_motor}. Puertas: {_puertas}";
        }
    }
}


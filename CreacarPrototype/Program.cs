// See https://aka.ms/new-console-template for more information

using CreacarPrototype.Prototypes;

#region Ford
// Ford
CarPrototype fordProto = new FordPrototype();

#region Fiesta
// 3 puertas
CarPrototype fiesta3 = fordProto.Clone();
fiesta3.Modelo = "Fiesta";
fiesta3.Motor = "1.6";
fiesta3.Puertas = 3;
Console.WriteLine(fiesta3.Show());

// 5 puertas
CarPrototype fiesta5 = fiesta3.Clone();
fiesta5.Puertas = 5;
Console.WriteLine(fiesta5.Show());
#endregion

#region Focus
// 3 puertas
CarPrototype focus3 = fordProto.Clone();
focus3.Modelo = "Focus";
focus3.Motor = "2.0";
focus3.Puertas = 3;
Console.WriteLine(focus3.Show());

// 5 puertas
CarPrototype focus5 = focus3.Clone();
focus5.Puertas = 5;
Console.WriteLine(focus5.Show());
#endregion

#endregion

#region Fiat

// Fiat
CarPrototype fiatProto = new FiatPrototype();

#region Palio
// 3 puertas
CarPrototype palio3 = fiatProto.Clone();
palio3.Modelo = "Palio";
palio3.Motor = "1.3";
palio3.Puertas = 3;
Console.WriteLine(palio3.Show());

// 5 puertas
CarPrototype palio5 = palio3.Clone();
palio5.Puertas = 5;
Console.WriteLine(palio5.Show());
#endregion

#region Siena
// 3 puertas
CarPrototype siena3 = fiatProto.Clone();
siena3.Modelo = "Siena";
siena3.Motor = "1.6";
siena3.Puertas = 3;
Console.WriteLine(siena3.Show());

// 5 puertas
CarPrototype siena5 = siena3.Clone();
siena5.Puertas = 5;
Console.WriteLine(siena5.Show());
#endregion

#endregion

Console.ReadKey();
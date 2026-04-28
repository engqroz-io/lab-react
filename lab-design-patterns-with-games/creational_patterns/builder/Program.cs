using builder;

var exercito = new Exercito();
CriadorDeSoldado criadorDeSoldado;
Soldado soldado;

// Criar um soldado de infantaria leve
criadorDeSoldado = new CriadorDeInfantariaLeve();
exercito.ConstruirSoldado(criadorDeSoldado);
soldado = criadorDeSoldado.ObterSoldado();
Console.WriteLine("Soldado de Infantaria Leve: {0}, {1}, {2}", soldado.Arma, soldado.Transporte, soldado.Foco);

// Criar um soldado de forças especiais
criadorDeSoldado = new CriadorDeForcasEspeciais();
exercito.ConstruirSoldado(criadorDeSoldado);
soldado = criadorDeSoldado.ObterSoldado();
Console.WriteLine("Soldado de Forças Especiais: {0}, {1}, {2}", soldado.Arma, soldado.Transporte, soldado.Foco);

Console.ReadKey();